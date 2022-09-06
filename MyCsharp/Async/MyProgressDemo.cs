using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharp.Async
{
    public class MyProgressDemo
    {
        async Task GetR()
        {
            await Task.Run((() =>
            {
                var progress = new Progress<int>(i => { Console.Out.WriteLine(i + $"%{i}"); });
                progress.ProgressChanged += ((sender, i) => { Console.Out.WriteLine($"sender:{i}"); });
            }));
            Thread.Sleep(200);
            Console.Out.WriteLine("任务完成");
        }

        public static void Execut()
        {
            MyProgressDemo demo = new MyProgressDemo();
            demo.GetR();
            Task.Delay(1000);
            Thread.Sleep(100);
        }
    }
}