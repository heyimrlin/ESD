using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESD
{
    class DataSent
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
    }
}
