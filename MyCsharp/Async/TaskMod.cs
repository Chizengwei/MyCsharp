using System;
using System.Threading.Tasks;

namespace MyCsharp.Async
{
    public class TaskMod
    {
        async Task<int> Delay1()
        {
            await Task.Delay(1000);
            Console.Out.WriteLine("1");
            return 1;
        }
        async Task<int> Delay2()
        {
            await Task.Delay(1000);
            Console.Out.WriteLine("2");
            return 2;
        }
        async Task<int> Delay3()
        {
            await Task.Delay(10000);
            Console.Out.WriteLine("3");
            return 3;
        }

        public static void Execut()
        {
            TaskMod mod = new TaskMod();
            var result=Task.WhenAny(mod.Delay1(), mod.Delay2(), mod.Delay3());
            var allResult = Task.WhenAll(mod.Delay1(), mod.Delay2());
            Console.Out.WriteLine("Done");
            Console.Out.WriteLine(result.Result.Result);
        }
    }
}