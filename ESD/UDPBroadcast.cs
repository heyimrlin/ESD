using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ESD
{
    class UDPBroadcast
    {
        public static Dictionary<string, string> gw_info = new Dictionary<string, string>();
        protected Thread receiveThread;

        public static string ReceiveData = "msg";
        public static string Handshake = "握手：发送 0；接收 0 ";
        private int send = 0;
        private int receive = 0;

        public void SendThread()
        {
            try
            {
                UdpClient UDPSend = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Broadcast, 9090);

                byte[] buf = System.Text.Encoding.Default.GetBytes("GETIP\r\n");

                receiveThread = new Thread(new ThreadStart(RecvThread));
                receiveThread.IsBackground = true;
                receiveThread.Start();

                while (true)
                {
                    UDPSend.Send(buf, buf.Length, endpoint);
                    send++;
                    Handshake = "握手：发送 " + send + "；接收 " + receive;
                    Thread.Sleep(5000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("<网关搜索异常> " + ex.Message, "系统提示");
            }
        }

        protected void RecvThread()
        {
            try
            {
                UdpClient UDPReceive = new UdpClient(new IPEndPoint(IPAddress.Any, 9090));
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);

                while (true)
                {
                    byte[] buf = UDPReceive.Receive(ref endpoint);
                    string IP = endpoint.Address.ToString();
                    string recData = System.Text.Encoding.Default.GetString(buf);

                    //处理广播接收数据，获取在线网关的ip地址
                    if (recData.Contains("SN:"))
                    {
                        gw_info.Add(recData.Replace("SN:", ""), IP);
                        receive++;
                        Handshake = "握手：发送 " + send + "；接收 " + receive;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("9090端口已被占用！", "系统提示");
                Application.Exit();
            }
        }
    }
}
