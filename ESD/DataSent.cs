using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESD
{
    public class DataSent
    {
        public static byte[] GetDevices(string gw_SN)   //获取当前连接的所有设备
        {
            string data_sent = "0800" + gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2) + "FE81";
            return Utils.HexstrToByte(data_sent);
        }

        public static byte[] NetPermission(string gw_SN)    //允许入网
        {
            string data_sent = "0800" + gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2) + "FE9F";
            return Utils.HexstrToByte(data_sent);
        }

        public static byte[] DeleteDevice(string gw_SN,string addr_Short,string addr_IEEE,string endpoint) //删除指定设备
        {
            string data_sent = "1500" + gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2) + "FE950C02";
            data_sent += addr_Short + addr_IEEE + endpoint;

            //byte[] head = Utils.HexstrToByte(data_sent);
            //byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            //byte[] aIEEE = System.Text.Encoding.Default.GetBytes(addr_IEEE);
            //byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);
            //return head.Concat(aShort).Concat(aIEEE).Concat(ePoint).ToArray();

            return Utils.HexstrToByte(data_sent);
        }

        public static byte[] GetSendData(string gw_SN, string addr_Short, string endpoint, byte type)    //根据操作类型获取发送指令
        {
            string tmp = "";
            //byte[] data_tmp = null;
            byte[] data_sent = null;
            
            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            //byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            //byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            switch (type)
            {
                case 0x00://获取状态数据
                    //tmp = "1500" + gw_SN + "FEA70C";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "030600680600082F3D";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1500" + gw_SN + "FEA70C" + addr_Short + endpoint + "030600680600082F3D";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
                case 0x10://打开离子风机
                    //tmp = "1500" + gw_SN + "FEA70C";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "030600680600280432";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1500" + gw_SN + "FEA70C" + addr_Short + endpoint + "030600680600280432";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
                case 0x11://关闭离子风机
                    //tmp = "1500" + gw_SN + "FEA70C";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "030600680600280331";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1500" + gw_SN + "FEA70C" + addr_Short + endpoint + "030600680600280331";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
                case 0x20://切换为自动状态
                    //tmp = "1600" + gw_SN + "FEA70D";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "03070068070028070137";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "03070068070028070137";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
                case 0x21://切换为手动状态
                    //tmp = "1600" + gw_SN + "FEA70D";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "03070068070028070036";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "03070068070028070036";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
                case 0x30://回复接收到异常上报数据
                    //tmp = "1600" + gw_SN + "FEA70D";
                    //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    //tmp = "03070068070000000007";
                    //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "03070068070000000007";
                    data_sent = Utils.HexstrToByte(tmp);
                    break;
            }

            return data_sent;
        }

        public static byte[] SetSpeed(string gw_SN, string addr_Short, string endpoint, int data)   //风速调节
        {
            string tmp = "";
            //byte[] data_tmp = null;
            byte[] data_sent = null;

            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            //byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            //byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            //tmp = "1600" + gw_SN + "FEA70D";
            //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
            //tmp = "0307006807002806"+data.ToString("X2")+(data+53).ToString("X2");
            //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
            tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "0307006807002806" + data.ToString("X2") + (data + 53).ToString("X2");
            data_sent = Utils.HexstrToByte(tmp);

            return data_sent;
        }

        public static byte[] SetAutoClean(string gw_SN, string addr_Short, string endpoint, int data)   //设置自动清洁
        {
            string tmp = "";
            //byte[] data_tmp = null;
            byte[] data_sent = null;

            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            //byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            //byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            //tmp = "1600" + gw_SN + "FEA70D";
            //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
            //tmp = "0307006807002806"+data.ToString("X2")+(data+53).ToString("X2");
            //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
            tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "0307006807002908" + data.ToString("X2") + (data + 56).ToString("X2");
            data_sent = Utils.HexstrToByte(tmp);

            return data_sent;
        }

        public static byte[] SetAlarmVoltage(string gw_SN, string addr_Short, string endpoint, int data)    //设置报警电压
        {
            string tmp = "";
            //byte[] data_tmp = null;
            byte[] data_sent = null;

            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            //byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            //byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            //tmp = "1600" + gw_SN + "FEA70D";
            //data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
            //tmp = "0307006807002806"+data.ToString("X2")+(data+53).ToString("X2");
            //data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
            tmp = "1600" + gw_SN + "FEA70D" + addr_Short + endpoint + "0307006807002909" + data.ToString("X2") + (data + 57).ToString("X2");
            data_sent = Utils.HexstrToByte(tmp);

            return data_sent;
        }
    }
}
