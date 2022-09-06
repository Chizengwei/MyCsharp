using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharp.MyTestCode
{
    public class PrintTest
    {
        static async Task Monitor()
        {
            await Task.Delay(1000);
            Console.Out.WriteLine("Delaying 1000");
            await Task.Delay(500);
            Console.Out.WriteLine("休眠结束");
        }

        static async void Go()
        {
            await Monitor();
        }

        public static void Execut()
        {
            Go();
            Thread.Sleep(5000);
        }
    }
}