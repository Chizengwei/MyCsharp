using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace MyCsharp.Async
{
    public class CountCharacter
    {
        public static readonly Stopwatch Stopwatch = new Stopwatch();

        public static readonly string adrr = "https://blog.csdn.net/";

        public static readonly string add1 = "https://blog.csdn.net";

        public async static Task<int> CountChar(int id, string adress)
        {
            var wc = new WebClient();
            Console.Out.WriteLine($"开始调用id{id}=:{Stopwatch.ElapsedMilliseconds}ms");
            var result = await wc.DownloadStringTaskAsync(adress);
            Console.Out.WriteLine($"结束调用id{id}={Stopwatch.ElapsedMilliseconds}ms");
            return result.Length;
        }

        private static void Extra(int id)
        {
            string s = "";
            for (int i = 0; i < 1000; i++)
            {
                s += (id + i);
            }

            Console.Out.WriteLine($"id :{id}Extra方法完成 :{Stopwatch.ElapsedMilliseconds}ms");
        }

        public static void Execut()
        {
            Stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Extra(i);
            }

            var v1 = CountChar(1, add1);
            var v2 = CountChar(2, adrr);
            Console.Out.WriteLine($"v1={v1.Result}");
            Console.Out.WriteLine($"v2={v2.Result}");

            Console.Out.WriteLine("Done");
            var c=Console.Read();
            Console.Out.WriteLine($"c={c}");
        }
    }
}