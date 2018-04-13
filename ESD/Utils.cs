using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ESD
{
    class Utils
    {
        public static byte[] HexstrToByte(string data)  //十六进制字符串转字节数组
        {
            int len = (data.Length) / 2;
            byte[] result = new byte[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = Convert.ToByte(data.Substring(i * 2, 2), 16);
            }
            return result;
        }

        public static string GetBroadcast()//获取广播地址
        {
            string ip_broadcast = "255.255.255.255";
            byte[] ip = null;
            byte[] ip_subnet = null;

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            foreach (ManagementObject nic in nics)
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    ip = IPAddress.Parse((nic["IPAddress"] as String[])[0]).GetAddressBytes();
                    ip_subnet = IPAddress.Parse((nic["IPSubnet"] as String[])[0]).GetAddressBytes();
                }
            }

            for (int i = 0; i<ip.Length; i++)
            {
                ip[i] = (byte)((~ip_subnet[i]) | ip[i]);
            }

            ip_broadcast = new IPAddress(ip).ToString();

            return ip_broadcast;
        }
    }
}
