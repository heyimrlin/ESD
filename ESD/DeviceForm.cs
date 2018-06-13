using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESD
{
    public partial class DeviceForm : Form
    {
        public static string gw_SN, addr_Short, endpoint;
        public static string dev_Name, hard_Version, soft_Version, work_Time, bal_Voltage, fan_Speed;
        public static string autoClean_Interval, alarm_Voltage;
        public static string work_Mode, fan_State, pressure_State;
        public static string error_Voltage, error_Electric, error_Bal, error_Fan;

        public DeviceForm()
        {
            InitializeComponent();
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            lab_devName.Text = dev_Name;

            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.GetSendData(gw_SN, addr_Short, endpoint, 0x00));//获取状态数据
            }
        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)//实时刷新数据
        {
            RefreshData();
        }

        private void RefreshData()  //实时刷新数据
        {
            lab_hardVersion.Text = hard_Version;
            lab_softVersion.Text = soft_Version;
            lab_workTime.Text = work_Time;
            lab_balVoltage.Text = bal_Voltage;
            lab_speed.Text = fan_Speed;
            lab_interval.Text = autoClean_Interval;
            lab_alarmvoltage.Text = alarm_Voltage;

            switch (work_Mode)
            {
                case "手动":
                    btn_manual.Checked = true;
                    break;
                case "自动":
                    btn_auto.Checked = true;
                    break;
            }

            switch (fan_State)
            {
                case "关闭":
                    btn_fanoff.Checked = true;
                    break;
                case "打开":
                    btn_fanon.Checked = true;
                    break;
            }

            switch (pressure_State)
            {
                case "关闭":
                    btn_pressureoff.Checked = true;
                    break;
                case "打开":
                    btn_pressureon.Checked = true;
                    break;
            }

            switch (error_Voltage)
            {
                case "正常":
                    btn_volnor.Checked = true;
                    break;
                case "异常":
                    btn_volabn.Checked = true;
                    break;
            }

            switch (error_Electric)
            {
                case "正常":
                    btn_elecnor.Checked = true;
                    break;
                case "异常":
                    btn_elecabn.Checked = true;
                    break;
            }

            switch (error_Bal)
            {
                case "正常":
                    btn_balnor.Checked = true;
                    break;
                case "异常":
                    btn_balabn.Checked = true;
                    break;
            }

            switch (error_Fan)
            {
                case "正常":
                    btn_fannor.Checked = true;
                    break;
                case "异常":
                    btn_fanabn.Checked = true;
                    break;
            }
        }

        private void btn_on_Click(object sender, EventArgs e)   //打开离子风机
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.GetSendData(gw_SN, addr_Short, endpoint, 0x10));
            }
        }

        private void btn_off_Click(object sender, EventArgs e)  //关闭离子风机
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.GetSendData(gw_SN, addr_Short, endpoint, 0x11));
            }
        }

        private void btn_SetSpeed_Click(object sender, EventArgs e) //风速调节
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.SetSpeed(gw_SN, addr_Short, endpoint,Decimal.ToInt32(num_speed.Value)));
            }
        }

        private void btn_setManual_Click(object sender, EventArgs e)    //切换为手动模式
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.GetSendData(gw_SN, addr_Short, endpoint, 0x20));
            }
        }

        private void btn_setAuto_Click(object sender, EventArgs e)  //切换为自动模式
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.GetSendData(gw_SN, addr_Short, endpoint, 0x21));
            }
        }

        private void DeviceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.FormState = false;

            hard_Version = soft_Version = work_Time = bal_Voltage = fan_Speed = "";
            work_Mode = "手动";
            fan_State = pressure_State = "关闭";
            error_Voltage = error_Electric = error_Bal = error_Fan = "正常";

            num_speed.Value = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dev_Name = lab_devName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btn_ACOpen_Click(object sender, EventArgs e)   //开启自动清洁
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.SetAutoClean(gw_SN, addr_Short, endpoint, Decimal.ToInt32(num_interval.Value)));
            }
        }

        private void btn_ACClose_Click(object sender, EventArgs e)  //关闭自动清洁
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.SetAutoClean(gw_SN, addr_Short, endpoint, 0));
            }
        }

        private void btn_SetAlarmV_Click(object sender, EventArgs e)    //设置报警电压
        {
            if (MainForm.handler != null && MainForm.handler.isConnected())
            {
                MainForm.handler.SendData(DataSent.SetAlarmVoltage(gw_SN, addr_Short, endpoint, Decimal.ToInt32(num_alarmV.Value)));
            }
        }
    }
}
