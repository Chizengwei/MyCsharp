using System;
using System.Net;

namespace MyCsharp.Net
{
    public class TcpTest
    {
        public static void Execut()
        {
            foreach (var VARIABLE in Dns.GetHostAddresses("www.baidu.com"))
            {
                Console.Out.WriteLine($"地址：{VARIABLE}");
            }
        }
    }
}