using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESD
{
    class Fan
    {
        private string Device_ID;   //2字节设备ID
        public string DeviceID
        {
            get { return Device_ID; }
            set { Device_ID = value; }
        }

        private string Device_Name; //设备名
        public string DeviceName
        {
            get { return Device_Name; }
            set { Device_Name = value; }
        }

        private string State_Net;   //联网状态
        public string NetState
        {
            get { return State_Net; }
            set { State_Net = value; }
        }

        private string State_Pressure;  //高压状态
        public string PressureState
        {
            get { return State_Pressure; }
            set { State_Pressure = value; }
        }

        private string State_Fan;   //风扇状态
        public string FanState
        {
            get { return State_Fan; }
            set { State_Fan = value; }
        }

        private string Voltage_Balance; //平衡电压
        public string BalanceVoltage
        {
            get { return Voltage_Balance; }
            set { Voltage_Balance = value; }
        }

        private string Error_Pressure;  //高压异常
        public string PressureError
        {
            get { return Error_Pressure; }
            set { Error_Pressure = value; }
        }

        private string Error_Fan;   //风扇异常
        public string FanError
        {
            get { return Error_Fan; }
            set { Error_Fan = value; }
        }

        private string Address_Short;   //2字节短地址
        public string ShorAddress
        {
            get { return Address_Short; }
            set { Address_Short = value; }
        }

        private string Address_IEEE;    //8字节IEEE地址
        public string IEEEAddress
        {
            get { return Address_IEEE; }
            set { Address_IEEE = value; }
        }

        private string endpoint;    //1字节EndPoint
        public string EndPoint
        {
            get { return endpoint; }
            set { endpoint = value; }
        }

        public Fan(string id, string name, string net, string pressure, string fan, string bal_voltage, string err_pressure, 
                string err_fan, string addr_short, string addr_ieee, string endpoint)
        {
            this.Device_ID = id;
            this.Device_Name = name;
            this.State_Net = net;
            this.State_Pressure = pressure;
            this.State_Fan = fan;
            this.Voltage_Balance = bal_voltage;
            this.Error_Pressure = err_pressure;
            this.Error_Fan = err_fan;
            this.Address_Short = addr_short;
            this.Address_IEEE = addr_ieee;
            this.EndPoint = endpoint;
        }
        
    }
}
