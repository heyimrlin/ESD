using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESD
{
    public partial class MainForm : Form
    {
        UDPBroadcast broadcast = null;
        Thread Thread_Broadcast = null;
        TCPHandler handler = null;
        private List<Fan> FanDevices = new List<Fan>();
        private Dictionary<string, Fan> FanSearch = new Dictionary<string, Fan>();

        public MainForm()
        {
            InitializeComponent();
            broadcast = new UDPBroadcast();
            Thread_Broadcast = new Thread(new ThreadStart(broadcast.SendThread));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread_Broadcast.IsBackground = true;
            Thread_Broadcast.Start();

            lab_IP.Text = "0.0.0.0";
            lab_Fans.Text = "0";
            lab_Connected.Text = "未连接";
        }

        private void Timer_sbTips_Tick(object sender, EventArgs e)  //加载状态栏信息
        {
            sb_tips0.Text = UDPBroadcast.Handshake;
            sb_tips1.Text = TCPHandler.State;
        }

        private void Timer_RefreshIPList_Tick(object sender, EventArgs e)   //加载网关设备信息
        {
            dgv_gwIP.Rows.Clear();

            List<string> SNIDList = new List<string>();
            foreach (DataGridViewRow row in dgv_gwIP.Rows)
            {
                if (row.Cells["Col_SNID"].Value != null)
                {
                    SNIDList.Add(row.Cells["Col_SNID"].Value.ToString());
                }
            }

            for (int i = 0; i < UDPBroadcast.gw_info.Count; i++)
            {
                string id = UDPBroadcast.gw_info.ElementAt(i).Key;
                string ip = UDPBroadcast.gw_info.ElementAt(i).Value;

                if (!SNIDList.Contains(id))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dgv_gwIP.Rows.Add(row);
                    dgv_gwIP.Rows[index].Cells[0].Value = id;
                    dgv_gwIP.Rows[index].Cells[1].Value = ip;
                }
            }
        }

        private void Timer_Search_Tick(object sender, EventArgs e)  //自动停止搜索设备
        {
            Timer_RefreshIPList.Enabled = false;
            UDPBroadcast.gw_info.Clear();
            Thread_Broadcast.Suspend();

            menu_search.Enabled = true;
            menu_stop.Enabled = false;
            Timer_Search.Enabled = false;
        }

        private void menu_search_Click(object sender, EventArgs e)  //搜索设备
        {
            Thread_Broadcast.Resume();
            Timer_RefreshIPList.Enabled = true;

            menu_search.Enabled = false;
            menu_stop.Enabled = true;
            Timer_Search.Enabled = true;
        }

        private void menu_stop_Click(object sender, EventArgs e)    //停止搜索
        {
            Timer_RefreshIPList.Enabled = false;
            UDPBroadcast.gw_info.Clear();
            Thread_Broadcast.Suspend();

            menu_search.Enabled = true;
            menu_stop.Enabled = false;
            Timer_Search.Enabled = false;
        }

        private void dgv_gwIP_DoubleClick(object sender, EventArgs e)   //双击连接网关设备
        {
            if (dgv_gwIP.RowCount>0 && dgv_gwIP.CurrentCell.Value != null)
            {
                lab_SNID.Text = dgv_gwIP.CurrentRow.Cells[0].Value.ToString();
                lab_IP.Text = dgv_gwIP.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                return;
            }

            IPAddress ip;
            try
            {
                ip = IPAddress.Parse(lab_IP.Text);//当前网关设备IP地址是否合法
            }
            catch (Exception error)
            {
                MessageBox.Show("<当前网关设备IP地址输入格式错误> " + error.Message, "系统提示");
                return;
            }

            handler = new TCPHandler(lab_IP.Text, 8001);
            Thread.Sleep(100);
            if (handler != null && handler.isConnected())
            {
                lab_Fans.Text = ""+dgv_fanList.RowCount;
                lab_Connected.Text = "已连接";
                dgv_gwIP.Enabled = false;
                Timer_Received.Enabled = true;

                menu_stop_Click(sender, e); //停止搜索网关设备

                Thread.Sleep(100);
                handler.SendData(DataSent.GetDevices(lab_SNID.Text));   //获取当前连接的所有设备
            }
            else
            {
                lab_IP.Text = "0.0.0.0";
                lab_SNID.Text = "";
                lab_Fans.Text = "0";
                lab_Connected.Text = "未连接";
                dgv_gwIP.Enabled = true;
                Timer_Received.Enabled = false;

                MessageBox.Show("连接失败，请重试！", "系统提示");
            }
        }

        private void btn_disconncet_Click(object sender, EventArgs e)   //断开与网关设备的连接
        {
            if (handler != null && handler.isConnected())
            {
                handler.Close();
                menu_search_Click(sender, e);   //开始搜索网关设备
            }
            lab_IP.Text = "0.0.0.0";
            lab_SNID.Text = "";
            lab_Fans.Text = "0";
            lab_Connected.Text = "未连接";
            dgv_gwIP.Enabled = true;
            Timer_Received.Enabled = false;
        }

        private void dgv_gwIP_MouseEnter(object sender, EventArgs e)    //设置dgv_gwIP提示信息
        {
            ToolTip p = new ToolTip();
            p.SetToolTip(this.dgv_gwIP, "双击连接网关设备！");
        }

        private void Timer_Received_Tick(object sender, EventArgs e)    //处理网关上传数据
        {
            for (int i = 0; i < TCPHandler.Data.Count;)
            {
                byte[] data = TCPHandler.Data.ElementAt(i);
                TCPHandler.Data.Remove(data);
                Handle_Data(data);
            }
        }

        private void Handle_Data(byte[] data)   //处理接收数据
        {
            switch (data[0])
            {
                case 0x01://获取所有设备时返回的数据
                    Parse_DeviceInfo(data);
                    break;
                case 0x29://删除指定设备时返回的数据
                    break;
                case 0x70://设备上传的数据
                    break;
            }
        }

        private void Parse_DeviceInfo(byte[] data)  //处理返回的设备信息
        {
            byte[] tmp = data.Skip(2).Take(2).ToArray();
            string addr_short = System.Text.Encoding.Default.GetString(tmp);
            string endpoint = data[4].ToString("X2");
            tmp = data.Skip(7).Take(2).ToArray();
            string device_id = System.Text.Encoding.Default.GetString(tmp);
            tmp = data.Skip(11).Take(data[10]).ToArray();
            string device_name = System.Text.Encoding.Default.GetString(tmp);

        }

        private void btn_netPermit_Click(object sender, EventArgs e)    //允许入网
        {
            if (handler != null && handler.isConnected())
            {
                handler.SendData(DataSent.NetPermission(lab_SNID.Text));
            }
        }

        private void btn_getDevices_Click(object sender, EventArgs e)   //获取设备
        {
            if (handler != null && handler.isConnected())
            {
                handler.SendData(DataSent.GetDevices(lab_SNID.Text));
            }
        }

        private void Refresh_FanList()  //刷新风机设备列表
        {
            dgv_fanList.Rows.Clear();

            for (int i = 0; i < this.FanDevices.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_fanList.Rows.Add(row);
                dgv_fanList.Rows[index].Cells[0].Value = this.FanDevices.ElementAt(i).DeviceID;
                dgv_fanList.Rows[index].Cells[1].Value = this.FanDevices.ElementAt(i).DeviceName;
                dgv_fanList.Rows[index].Cells[2].Value = this.FanDevices.ElementAt(i).NetState;
                dgv_fanList.Rows[index].Cells[3].Value = this.FanDevices.ElementAt(i).PressureState;
                dgv_fanList.Rows[index].Cells[4].Value = this.FanDevices.ElementAt(i).FanState;
                dgv_fanList.Rows[index].Cells[5].Value = this.FanDevices.ElementAt(i).BalanceVoltage;
                dgv_fanList.Rows[index].Cells[6].Value = this.FanDevices.ElementAt(i).PressureError;
                dgv_fanList.Rows[index].Cells[7].Value = this.FanDevices.ElementAt(i).FanError;
                dgv_fanList.Rows[index].Cells[8].Value = this.FanDevices.ElementAt(i).ShorAddress;
                dgv_fanList.Rows[index].Cells[9].Value = this.FanDevices.ElementAt(i).IEEEAddress;
                dgv_fanList.Rows[index].Cells[10].Value = this.FanDevices.ElementAt(i).EndPoint;
            }
        }
    }
}
