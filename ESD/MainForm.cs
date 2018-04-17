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
using System.Xml;

namespace ESD
{
    public partial class MainForm : Form
    {
        UDPBroadcast broadcast = null;
        Thread Thread_Broadcast = null;
        public static TCPHandler handler = null;
        private Dictionary<string, Fan> FanList = new Dictionary<string, Fan>();

        private XmlDocument document = new XmlDocument();

        Form device = new DeviceForm();
        public static bool FormState = false;
        public static bool Receiving = false;

        public MainForm()
        {
            InitializeComponent();
            broadcast = new UDPBroadcast();
            Thread_Broadcast = new Thread(new ThreadStart(broadcast.SendThread));

            document.Load(Application.StartupPath+"\\DeviceName.xml");
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

            this.FanList.Clear();
            Refresh_FanList();
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
                    if (data[3] == 0x95)
                    {
                        Parse_DeleteDevice(data);
                    }
                    break;
                case 0x70://设备上传的数据
                    Parse_DeviceState(data);
                    break;
            }
        }

        private void Parse_DeviceInfo(byte[] data)  //处理返回的设备信息
        {
            if (data.Length < 30)
            {
                TCPHandler.State = "获取设备失败！";
                return;
            }

            Fan newFan = new Fan();

            newFan.DeviceName = "新风机设备";
            newFan.NetState = "打开";
            newFan.PressureError = "无";
            newFan.FanError = "无";
            newFan.PressureState = "未知";
            newFan.FanState = "未知";

            //短地址
            byte[] tmp = data.Skip(2).Take(2).ToArray();
            //string addr_short = System.Text.Encoding.Default.GetString(tmp);
            string addr_short = tmp[0].ToString("X2") + tmp[1].ToString("X2");
            newFan.ShorAddress = addr_short;

            XmlElement list = document.DocumentElement;
            foreach (XmlNode fan in list.ChildNodes)
            {
                string addr = fan.FirstChild.InnerText;
                string name = fan.LastChild.InnerText;
                if (addr.Equals(addr_short))
                {
                    newFan.DeviceName = name;
                }
            }

            //EndPoint
            tmp = data.Skip(4).Take(1).ToArray();
            //string endpoint = System.Text.Encoding.Default.GetString(tmp);
            string endpoint = tmp[0].ToString("X2");
            newFan.EndPoint = endpoint;

            //设备ID
            tmp = data.Skip(7).Take(2).ToArray();
            //string device_id = System.Text.Encoding.Default.GetString(tmp);
            string device_id = tmp[1].ToString("X2") + tmp[0].ToString("X2");
            newFan.DeviceID = device_id;

            //8字节IEEE地址
            tmp = data.Skip(11 + data[10] + 1).Take(8).ToArray();
            //string addr_ieee = System.Text.Encoding.Default.GetString(tmp);
            string addr_ieee = tmp[0].ToString("X2") + tmp[1].ToString("X2") + tmp[2].ToString("X2") + tmp[3].ToString("X2") +
                tmp[4].ToString("X2") + tmp[5].ToString("X2") + tmp[6].ToString("X2") + tmp[7].ToString("X2");
            newFan.IEEEAddress = addr_ieee;

            if (!FanList.Keys.Contains(addr_short))
            {
                FanList.Add(addr_short, newFan);
            }

            TCPHandler.State = "获取设备成功！";
            Refresh_FanList();
        }

        private void Parse_DeleteDevice(byte[] data)    //处理删除指定设备时返回的数据
        {
            if (data.Length==data[1] && data[3] == 0x95)
            {
                TCPHandler.State = "删除设备成功！";
            }
            else
            {
                TCPHandler.State = "删除设备失败！";
            }
        }

        private void Parse_DeviceState(byte[] data) //处理返回的设备状态数据
        {
            if (data.Length != data[1] + 2)
            {
                TCPHandler.State = "更新设备状态失败！";
                return;
            }

            //短地址
            byte[] tmp = data.Skip(2).Take(2).ToArray();
            string addr_short = tmp[0].ToString("X2") + tmp[1].ToString("X2");
            //string addr_short = System.Text.Encoding.Default.GetString(tmp);
            
            //EndPoint
            tmp = data.Skip(4).Take(1).ToArray();
            string endpoint = tmp[0].ToString("X2");
            //string endpoint = System.Text.Encoding.Default.GetString(tmp);

            //RealData
            byte[] data_real;
            if (data[12] == 0x68 && data[15] == 0x80 && data[16] == 0x2F)   //设备状态数据
            {
                data_real = data.Skip(17).Take(13).ToArray();

                string ver_hard = "" + data_real[0];
                string ver_soft = "" + data_real[1];

                tmp = data_real.Skip(3).Take(2).ToArray();
                string work_time = ""+BitConverter.ToInt16(tmp, 0);

                string work_mode = (data_real[9]&1)==1?"自动":"手动";
                string fan_state = (data_real[9] & 64) == 64 ? "打开" : "关闭";
                string pressure_state = (data_real[9] & 128) == 128 ? "打开" : "关闭";

                tmp = data_real.Skip(10).Take(2).ToArray();
                string work_voltage="";
                if ((tmp[1] & 128) == 128)
                {
                    tmp[1] -= 128;
                    work_voltage = "-"+BitConverter.ToInt16(tmp,0);
                }
                else
                {
                    work_voltage =  "" + BitConverter.ToInt16(tmp, 0);
                }
                 

                string fan_speed = "" + data_real[12];

                if (FanList.Keys.Contains<string>(addr_short)==true)
                {
                    Fan fan = new Fan();
                    FanList.TryGetValue(addr_short, out fan);

                    fan.FanState = fan_state;
                    fan.PressureState = pressure_state;
                    fan.BalanceVoltage = work_voltage;

                    FanList[addr_short] = fan;

                    Refresh_FanList();
                }

                if (FormState==true && addr_short == DeviceForm.addr_Short)
                {
                    DeviceForm.hard_Version = ver_hard;
                    DeviceForm.soft_Version = ver_soft;
                    DeviceForm.work_Time = work_time;
                    DeviceForm.bal_Voltage = work_voltage;
                    DeviceForm.fan_Speed = fan_speed;
                    DeviceForm.work_Mode = work_mode;
                    DeviceForm.fan_State = fan_state;
                    DeviceForm.pressure_State = pressure_state;
                }
            }
            else if (data[12] == 0x68 && data[15] == 0xC8 && data[16] == 0x00)  //设备异常状态数据
            {
                string device_voltage = (data[17] & 1) ==1? "异常" : "正常";
                string device_electric = (data[17] & 2) == 2 ? "异常" : "正常";
                string balance_voltage = (data[17] & 4) == 4 ? "异常" : "正常";
                string fan_error = (data[17] & 8) == 8 ? "异常" : "正常";

                if (FanList.Keys.Contains(addr_short))
                {
                    Fan fan = new Fan();
                    FanList.TryGetValue(addr_short, out fan);

                    fan.PressureError = device_voltage;
                    fan.FanError = fan_error;

                    FanList[addr_short] = fan;

                    Refresh_FanList();
                }

                if (FormState == true && addr_short == DeviceForm.addr_Short)
                {
                    DeviceForm.error_Voltage = device_voltage;
                    DeviceForm.error_Electric = device_electric;
                    DeviceForm.error_Bal = balance_voltage;
                    DeviceForm.error_Fan = fan_error;
                }

                if (handler != null && handler.isConnected())   //回复接收到异常上报数据
                {
                    handler.SendData(DataSent.GetSendData(lab_SNID.Text, addr_short, endpoint, 0x30));
                }
            }
            else
            {
                return;
            }

            TCPHandler.State = "更新设备状态成功！";
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
            Fan fan;

            for (int i = 0; i < this.FanList.Count; i++)
            {
                fan = this.FanList.ElementAt(i).Value;

                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_fanList.Rows.Add(row);

                dgv_fanList.Rows[index].Cells[0].Value = fan.DeviceID;
                dgv_fanList.Rows[index].Cells[1].Value = fan.DeviceName;
                dgv_fanList.Rows[index].Cells[2].Value = fan.NetState;
                dgv_fanList.Rows[index].Cells[3].Value = fan.PressureState;
                dgv_fanList.Rows[index].Cells[4].Value = fan.FanState;
                dgv_fanList.Rows[index].Cells[5].Value = fan.BalanceVoltage;
                dgv_fanList.Rows[index].Cells[6].Value = fan.PressureError;
                dgv_fanList.Rows[index].Cells[7].Value = fan.FanError;
                dgv_fanList.Rows[index].Cells[8].Value = fan.ShorAddress;
                dgv_fanList.Rows[index].Cells[9].Value = fan.IEEEAddress;
                dgv_fanList.Rows[index].Cells[10].Value = fan.EndPoint;
            }

            lab_Fans.Text = "" + dgv_fanList.RowCount;
        }

        private void cMenu_FanList_Opened(object sender, EventArgs e)   //弹出菜单初始化设置
        {
            if (dgv_fanList.RowCount > 0)
            {
                cMenu_Delete.Enabled = true;
                cMenu_Check.Enabled = true;
            }
            else
            {
                cMenu_Delete.Enabled = false;
                cMenu_Check.Enabled = false;
            }
        }

        private void cMenu_Delete_Click(object sender, EventArgs e) //删除指定设备
        {
            if (dgv_fanList.RowCount > 0)
            {
                string addr_Short = dgv_fanList.CurrentRow.Cells[8].Value.ToString();
                string addr_IEEE="";
                if(dgv_fanList.CurrentRow.Cells[9].Value!=null)
                {
                    addr_IEEE = dgv_fanList.CurrentRow.Cells[9].Value.ToString();
                }
                string endpoint = dgv_fanList.CurrentRow.Cells[10].Value.ToString();

                if (handler != null && handler.isConnected())
                {
                    handler.SendData(DataSent.DeleteDevice(lab_SNID.Text,addr_Short,addr_IEEE,endpoint));
                }
            }
        }

        private void cMenu_Check_Click(object sender, EventArgs e)  //查看设备状态
        {
            if (dgv_fanList.RowCount > 0)
            {
                DeviceForm.gw_SN = lab_SNID.Text;
                DeviceForm.addr_Short = dgv_fanList.CurrentRow.Cells[8].Value.ToString();
                DeviceForm.endpoint = dgv_fanList.CurrentRow.Cells[10].Value.ToString();
                DeviceForm.dev_Name = dgv_fanList.CurrentRow.Cells[1].Value.ToString();

                FormState = true;

                device.ShowDialog();
                if (device.DialogResult == DialogResult.OK)
                {
                    string aShort = DeviceForm.addr_Short;

                    if (FanList.Keys.Contains(aShort))
                    {
                        Fan fan = new Fan();
                        FanList.TryGetValue(aShort, out fan);
                        fan.DeviceName = DeviceForm.dev_Name;

                        FanList[aShort] = fan;

                        Refresh_FanList();

                        //在修改风机设备的名称之后将数据保存到xml文件中
                        XmlElement list = document.DocumentElement;
                        bool flag = true;
                        foreach (XmlNode nfan in list.ChildNodes)
                        {
                            string addr = nfan.FirstChild.InnerText;
                            string name = nfan.LastChild.InnerText;

                            if (addr.Equals(DeviceForm.addr_Short))
                            {
                                nfan.LastChild.InnerText = DeviceForm.dev_Name;
                                flag = false;
                            }
                        }

                        if (flag)
                        {
                            XmlElement nFan = document.CreateElement("fan");
                            XmlElement fAddr = document.CreateElement("addr");
                            fAddr.InnerText = DeviceForm.addr_Short;
                            XmlElement fName = document.CreateElement("name");
                            fName.InnerText = DeviceForm.dev_Name;

                            nFan.AppendChild(fAddr);
                            nFan.AppendChild(fName);

                            list.AppendChild(nFan);

                            document.Save(Application.StartupPath + "\\DeviceName.xml");
                        }

                        MessageBox.Show("修改成功！", "操作提示");
                    }
                }
            }
        }
    }
}
