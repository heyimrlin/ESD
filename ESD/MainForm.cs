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
    public struct CustomNode
    {
        public string Addr, DeviceID, Name;
    }

    public partial class MainForm : Form
    {
        UDPBroadcast broadcast = null;
        Thread Thread_Broadcast = null;
        public static TCPHandler handler = null;
        private Dictionary<string, Fan> FanList = new Dictionary<string, Fan>();
        private Dictionary<string, Fan> GroupFanList = new Dictionary<string, Fan>();

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
            newFan.AutoCleanInterval = "未知";
            newFan.AlarmVoltage = "未知";

            //短地址
            byte[] tmp = data.Skip(2).Take(2).ToArray();
            //string addr_short = System.Text.Encoding.Default.GetString(tmp);
            string addr_short = tmp[0].ToString("X2") + tmp[1].ToString("X2");
            newFan.ShorAddress = addr_short;

            //匹配已保存的设备名
            XmlElement list = document.DocumentElement;
            XmlNodeList group = list.ChildNodes;
            bool flag = true;
            foreach (XmlElement gp in group)
            {
                foreach (XmlNode fan in gp.ChildNodes)
                {
                    string addr = fan.FirstChild.InnerText;
                    string name = fan.LastChild.InnerText;
                    if (addr.Equals(addr_short))
                    {
                        newFan.DeviceName = name;
                        flag = false;
                    }
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

            //若未在数据库中保存过设备，则添加
            if (flag)
            {
                foreach (XmlElement xe in group)
                {
                    if (xe.GetAttribute("name").Equals("未分组"))
                    {
                        XmlElement fan = document.CreateElement("fan");
                        XmlElement addr = document.CreateElement("addr");
                        addr.InnerText = addr_short;
                        XmlElement devid = document.CreateElement("deviceid");
                        devid.InnerText = device_id;
                        XmlElement name = document.CreateElement("name");
                        name.InnerText = "新风机设备";

                        fan.AppendChild(addr);
                        fan.AppendChild(devid);
                        fan.AppendChild(name);

                        xe.AppendChild(fan);

                        document.Save(Application.StartupPath + "\\DeviceName.xml");
                    }
                }
            }

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
            if (data.Length != 35)
            {
                return;
            }
            else if (data.Length != data[1] + 2)
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
                data_real = data.Skip(17).Take(17).ToArray();

                //版本信息
                string ver_hard = "" + data_real[0];
                string ver_soft = "" + data_real[1];

                //运行时间
                tmp = data_real.Skip(3).Take(2).ToArray();
                string work_time = ""+BitConverter.ToInt16(tmp, 0);

                //风机运行状态
                string work_mode = (data_real[9]&1)==1?"自动":"手动";
                string fan_state = (data_real[9] & 64) == 64 ? "打开" : "关闭";
                string pressure_state = (data_real[9] & 128) == 128 ? "打开" : "关闭";

                //工作电压
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

                work_voltage = Convert.ToString(int.Parse(work_voltage) / 1000);

                //离子风机风速
                string fan_speed = "" + data_real[12];

                //设备ID
                tmp = data_real.Skip(13).Take(2).ToArray();
                string device_id = tmp[0].ToString("X2") + tmp[1].ToString("X2");

                //自动清洁间隔
                string autoclean_interval = "" + data_real[15];

                //报警电压
                string alarm_voltage = "" + data_real[16];

                if (FanList.Keys.Contains<string>(addr_short)==true)
                {
                    Fan fan = new Fan();
                    FanList.TryGetValue(addr_short, out fan);

                    fan.FanState = fan_state;
                    fan.PressureState = pressure_state;
                    fan.BalanceVoltage = work_voltage;
                    fan.DeviceID = device_id;
                    fan.AutoCleanInterval = autoclean_interval;
                    fan.AlarmVoltage = alarm_voltage;

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
                    DeviceForm.autoClean_Interval = autoclean_interval;
                    DeviceForm.alarm_Voltage = alarm_voltage;
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
                string device_id = data[19].ToString("X2") + data[20].ToString("X2");

                if (FanList.Keys.Contains(addr_short))
                {
                    Fan fan = new Fan();
                    FanList.TryGetValue(addr_short, out fan);

                    fan.PressureError = device_voltage;
                    fan.FanError = fan_error;
                    fan.DeviceID = device_id;

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

        private void Refresh_FanList_Group(Dictionary<string,Fan> GroupList)    //刷新分组设备列表
        {
            dgv_fanList_Group.Rows.Clear();
            Fan fan;

            for (int i = 0; i < GroupList.Count; i++)
            {
                fan = GroupList.ElementAt(i).Value;

                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_fanList_Group.Rows.Add(row);

                dgv_fanList_Group.Rows[index].Cells[0].Value = fan.DeviceID;
                dgv_fanList_Group.Rows[index].Cells[1].Value = fan.DeviceName;
                dgv_fanList_Group.Rows[index].Cells[2].Value = fan.PressureState;
                dgv_fanList_Group.Rows[index].Cells[3].Value = fan.FanState;
                dgv_fanList_Group.Rows[index].Cells[4].Value = fan.BalanceVoltage;
                dgv_fanList_Group.Rows[index].Cells[5].Value = fan.ShorAddress;
                dgv_fanList_Group.Rows[index].Cells[6].Value = fan.IEEEAddress;
                dgv_fanList_Group.Rows[index].Cells[7].Value = fan.EndPoint;
            }
        }

        private void cMenu_FanList_Opened(object sender, EventArgs e)   //弹出菜单初始化设置
        {
            if (dgv_fanList.RowCount > 0)
            {
                cMenu_Delete.Enabled = true;
                cMenu_Check.Enabled = true;
                //cMenu_Group.Enabled = true;
            }
            else
            {
                cMenu_Delete.Enabled = false;
                cMenu_Check.Enabled = false;
                //cMenu_Group.Enabled = false;
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
                    FanList.Remove(addr_Short);
                    Refresh_FanList();
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
                        XmlNodeList group = list.ChildNodes;
                        foreach (XmlElement gp in group)
                        {
                            foreach (XmlElement nfan in gp)
                            {
                                string addr = nfan.FirstChild.InnerText;
                                string name = nfan.LastChild.InnerText;

                                if (addr.Equals(DeviceForm.addr_Short))
                                {
                                    nfan.LastChild.InnerText = DeviceForm.dev_Name;
                                    document.Save(Application.StartupPath + "\\DeviceName.xml");
                                }
                            }
                        }

                        MessageBox.Show("修改成功！", "操作提示");
                    }
                }
            }
        }

        private void cMenu_Group_Click(object sender, EventArgs e)  //分组操作
        {
            panel_group.BringToFront();
            Refresh_GroupList();
        }

        private void Refresh_GroupList()    //刷新分组列表
        {
            XmlElement list = document.DocumentElement;
            XmlNodeList group = list.ChildNodes;

            TreeNode root = tree_devices.Nodes[0];
            root.Nodes.Clear();

            foreach (XmlElement gp in group)
            {
                string gp_name = gp.GetAttribute("name");
                TreeNode[] children = new TreeNode[gp.ChildNodes.Count];
                for (int i = 0; i < gp.ChildNodes.Count; i++)
                {
                    XmlNode fan = gp.ChildNodes.Item(i);

                    CustomNode node = new CustomNode();
                    node.Addr = fan.FirstChild.InnerText;
                    node.DeviceID = fan.ChildNodes[1].InnerText;
                    node.Name = fan.LastChild.InnerText;

                    TreeNode newFan = new TreeNode(node.Name);
                    newFan.Tag = node;

                    children[i] = newFan;
                }
                TreeNode newGroup = new TreeNode(gp_name, children);
                root.Nodes.Add(newGroup);
            }

            tree_devices.SelectedNode = root;
            tree_devices.ExpandAll();
        }

        private void btn_back_Click(object sender, EventArgs e) //分组操作——返回
        {
            dgv_fanList.BringToFront();
        }

        private void btn_gn_save_Click(object sender, EventArgs e)  //分组操作——保存分组名
        {
            if (lab_groupName.Text != lab_previous.Text)
            {
                XmlElement list = document.DocumentElement;
                XmlNodeList groups = list.ChildNodes;
                foreach (XmlElement group in groups)
                {
                    string name = group.GetAttribute("name");
                    if (name.Equals(lab_previous.Text))
                    {
                        group.SetAttribute("name", lab_groupName.Text);
                        lab_previous.Text = lab_groupName.Text;
                    }
                }

                document.Save(Application.StartupPath + "\\DeviceName.xml");
                Refresh_GroupList();
            }
        }

        private void tree_devices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current_node = tree_devices.SelectedNode;
            this.GroupFanList.Clear();

            int level = current_node.Level;
            switch (level)
            {
                case 0:
                    lab_groupName.Text = "所有设备";
                    lab_groupName.Enabled = false;
                    btn_gn_save.Enabled = false;
                    btn_del_group.Enabled = false;
                    this.GroupFanList = new Dictionary<string, Fan>(this.FanList);
                    Refresh_FanList_Group(this.GroupFanList);
                    break;
                case 1:
                    lab_groupName.Text = current_node.Text;
                    lab_previous.Text = current_node.Text;
                    if ("未分组".Equals(current_node.Text))
                    {
                        btn_gn_save.Enabled = false;
                        lab_groupName.Enabled = false;
                        btn_del_group.Enabled = false;
                    }
                    else
                    {
                        btn_gn_save.Enabled = true;
                        lab_groupName.Enabled = true;
                        btn_del_group.Enabled = true;
                    }
                    
                    foreach (TreeNode child in current_node.Nodes)
                    {
                        CustomNode node = (CustomNode)child.Tag;
                        string addr = node.Addr;
                        Fan fan = new Fan();
                        this.FanList.TryGetValue(addr, out fan);
                        if (fan != null)
                        {
                            this.GroupFanList.Add(addr, fan);
                        }
                    }
                    Refresh_FanList_Group(this.GroupFanList);

                    break;
                case 2:
                    lab_groupName.Text = current_node.Parent.Text;
                    lab_groupName.Enabled = false;
                    btn_gn_save.Enabled = false;
                    btn_del_group.Enabled = false;

                    CustomNode node_spe = (CustomNode)current_node.Tag;
                    string addr_spe = node_spe.Addr;
                    Fan fan_spe = new Fan();
                    this.FanList.TryGetValue(addr_spe, out fan_spe);
                    if (fan_spe != null)
                    {
                        this.GroupFanList.Add(addr_spe, fan_spe);
                    }
                    Refresh_FanList_Group(this.GroupFanList);

                    break;
            }
        }

        private void btn_SetAlarmV_Click(object sender, EventArgs e)    //组操作——设置报警电压
        {
            if (handler != null && handler.isConnected())
            {
                foreach (Fan fan in this.GroupFanList.Values)
                {
                    string gw_SN = lab_SNID.Text;
                    string addr_Short = fan.ShorAddress;
                    string endpoint = fan.EndPoint;

                    handler.SendData(DataSent.SetAlarmVoltage(gw_SN, addr_Short, endpoint, Decimal.ToInt32(num_alarmV.Value)));
                }
            }
        }

        private void btn_ACOpen_Click(object sender, EventArgs e)   //组操作——开启自动清洁
        {
            if (handler != null && handler.isConnected())
            {
                foreach (Fan fan in this.GroupFanList.Values)
                {
                    string gw_SN = lab_SNID.Text;
                    string addr_Short = fan.ShorAddress;
                    string endpoint = fan.EndPoint;

                    handler.SendData(DataSent.SetAutoClean(gw_SN, addr_Short, endpoint, Decimal.ToInt32(num_interval.Value)));
                }
            }
        }

        private void btn_ACClose_Click(object sender, EventArgs e)  //组操作——关闭自动清洁
        {
            if (handler != null && handler.isConnected())
            {
                foreach (Fan fan in this.GroupFanList.Values)
                {
                    string gw_SN = lab_SNID.Text;
                    string addr_Short = fan.ShorAddress;
                    string endpoint = fan.EndPoint;

                    handler.SendData(DataSent.SetAutoClean(gw_SN, addr_Short, endpoint, 0));
                }
            }
        }

        private void btn_new_group_Click(object sender, EventArgs e)    //新建分组
        {
            XmlElement list = document.DocumentElement;
            XmlElement group = document.CreateElement("group");
            group.SetAttribute("name", "未分组"+DateTime.Now.Millisecond);
            list.AppendChild(group);
            document.Save(Application.StartupPath + "\\DeviceName.xml");
            Refresh_GroupList();
        }

        private void btn_del_group_Click(object sender, EventArgs e)    //删除分组
        {
            XmlElement list = document.DocumentElement;
            XmlNodeList groups = list.ChildNodes;
            XmlNode[] children = new XmlNode[]{};
            foreach (XmlElement group in groups)
            {
                string name = group.GetAttribute("name");
                if (name.Equals("未分组"))
                {
                    continue;
                }
                if (name.Equals(lab_groupName.Text))
                {
                    int length = group.ChildNodes.Count;
                    children = new XmlElement[length];
                    for (int i = 0; i < length; i++)
                    {
                        children[i] = group.ChildNodes[i];
                    }
                    list.RemoveChild(group);
                }
            }
            foreach (XmlElement group in groups)
            {
                string name = group.GetAttribute("name");
                if (name.Equals("未分组"))
                {
                    for (int i = 0; i < children.Length; i++)
                    {
                        group.AppendChild(children[i]);
                    }
                }
            }
            document.Save(Application.StartupPath + "\\DeviceName.xml");
            Refresh_GroupList();
        }

        private void cMenu_GroupFanList_Opened(object sender, EventArgs e)
        {
            if (tree_devices.SelectedNode.Level == 2)
            {
                cMenu_AddTo.Enabled = true;
                cMenu_AddTo.DropDownItems.Clear();

                XmlElement list = document.DocumentElement;
                XmlNodeList groups = list.ChildNodes;
                foreach (XmlElement group in groups)
                {
                    string name = group.GetAttribute("name");
                    ToolStripMenuItem item = new ToolStripMenuItem(name);
                    item.Click += new EventHandler(MenuClicked);

                    if (tree_devices.SelectedNode.Parent.Text == name)
                    {
                        item.Enabled = false;
                    }

                    cMenu_AddTo.DropDownItems.Add(item);
                }
            }
            else
            {
                cMenu_AddTo.Enabled = false;
            }
        }

        private void MenuClicked(Object sender, EventArgs e)
        {
            TreeNode current_node = tree_devices.SelectedNode;
            CustomNode node = (CustomNode)current_node.Tag;
            string addr = node.Addr;

            XmlElement list = document.DocumentElement;
            XmlNodeList groups = list.ChildNodes;
            XmlElement child = null;
            foreach (XmlElement group in groups)
            {
                foreach (XmlElement fan in group)
                {
                    if (fan.ChildNodes[0].InnerText == addr)
                    {
                        child = fan;
                    }
                }
            }

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            foreach (XmlElement group in groups)
            {
                string name = group.GetAttribute("name");
                if (name.Equals(item.Text))
                {
                    group.AppendChild(child);
                }
            }

            document.Save(Application.StartupPath + "\\DeviceName.xml");
            Refresh_GroupList();
        }
    }
}
