using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharp.MyTestCode
{
    public class NewWordDemo
    {
        public static void MyFunc()
        {
            Task<int> result = Task.Run((() =>
            {
                Console.Out.WriteLine("Hello,C#");
                Thread.Sleep(5000);
                Console.Out.WriteLine("正在休眠中.....");
                return 3;
            }));
            Thread.Sleep(100);
            Console.Out.WriteLine("切换到主线程....");
            Console.Out.WriteLine(result.Result);
            Console.Out.WriteLine("主线程最后的执行语句？？？？？");
        }
    }
}