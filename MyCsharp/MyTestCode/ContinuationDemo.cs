using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCsharp.MyTestCode
{
    public class ContinuationDemo
    {
        static Task GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() => { Console.Out.WriteLine("S"); });
        }

        public static void Execut()
        {
            GetPrimesCountAsync(1000000 + 2, 1000000).GetAwaiter();
            Console.Out.WriteLine("Done");
        }
    }
}