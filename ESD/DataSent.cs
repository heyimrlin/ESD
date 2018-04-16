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
            byte[] head = Utils.HexstrToByte(data_sent);
            byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            byte[] aIEEE = System.Text.Encoding.Default.GetBytes(addr_IEEE);
            byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            return head.Concat(aShort).Concat(aIEEE).Concat(ePoint).ToArray();
        }

        public static byte[] GetSendData(string gw_SN, string addr_Short, string endpoint, byte type)    //根据操作类型获取发送指令
        {
            string tmp = "";
            byte[] data_tmp = null;
            byte[] data_sent = null;
            
            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            switch (type)
            {
                case 0x00://获取状态数据
                    tmp = "1500" + gw_SN + "FEA70C";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "030601680500082F3C";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
                case 0x10://打开离子风机
                    tmp = "1500" + gw_SN + "FEA70C";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "030601680500080431";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
                case 0x11://关闭离子风机
                    tmp = "1500" + gw_SN + "FEA70C";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "030601680500280330";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
                case 0x20://切换为自动状态
                    tmp = "1600" + gw_SN + "FEA70D";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "03070168060028070136";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
                case 0x21://切换为手动状态
                    tmp = "1600" + gw_SN + "FEA70D";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "03070168060028070036";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
                case 0x30://回复接收到异常上报数据
                    tmp = "1600" + gw_SN + "FEA70D";
                    data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
                    tmp = "03070168060000000036";
                    data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();
                    break;
            }

            return data_sent;
        }

        public static byte[] SetSpeed(string gw_SN, string addr_Short, string endpoint, int data)   //风速调节
        {
            string tmp = "";
            byte[] data_tmp = null;
            byte[] data_sent = null;

            gw_SN = gw_SN.Substring(6, 2) + gw_SN.Substring(4, 2) + gw_SN.Substring(2, 2) + gw_SN.Substring(0, 2);
            byte[] aShort = System.Text.Encoding.Default.GetBytes(addr_Short);
            byte[] ePoint = System.Text.Encoding.Default.GetBytes(endpoint);

            tmp = "1600" + gw_SN + "FEA70D";
            data_tmp = Utils.HexstrToByte(tmp).Concat(aShort).Concat(ePoint).ToArray();
            tmp = "0307016806002806"+data.ToString("X2")+"36";
            data_sent = data_tmp.Concat(Utils.HexstrToByte(tmp)).ToArray();

            return data_sent;
        }
    }
}
