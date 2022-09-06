using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharp.MyTestCode
{
    public class AsyncDemo
    {
        public static readonly object LOCK_OBJ = new object();
        private static int count = 0;

        public async static void Gos()
        {
            count++;
            Task<int> task = Task.Run((() =>
            {
                Console.Out.WriteLine("Task Running");
                count *= 2 + 100;
                Console.Out.WriteLine($"异步线程Count=:{count}");
                Thread.Sleep(1000);
                for (int i = 0; i < 5; i++)
                {
                    Console.Out.Write($"Count Loop:{count *= (i + 1)} ");
                    Thread.Sleep(500);
                }

                return count;
            }));
            Console.Out.WriteLine("主线程开始等待.....");
            task.Wait();
            await task;
            count *= 3;
            Console.Out.WriteLine($"主线程的Count={count + task.Result}");
        }

        public static void Execut()
        {
            int tempCount = 0;
            Task.Run((() =>
            {
                lock (LOCK_OBJ)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(10);
                        tempCount++;
                        Console.Out.WriteLine($"第一个线程temp={tempCount}");
                    }
                }
            }));
            Task.Run((() =>
            {
                Console.Out.WriteLine($"CurrentState={Thread.CurrentContext}");
                lock (LOCK_OBJ)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(10);
                        tempCount += 2;
                        Console.Out.WriteLine($"第二个线程temp={tempCount}");
                    }
                }
            }));
            Thread.Sleep(1000);
#pragma warning disable 4014
            Demo.Go();
#pragma warning restore 4014
            Console.Out.WriteLine("Done");
        }

        public static readonly AsyncDemo Demo = new AsyncDemo();

        async Task Go()
        {
            await PrintAnswer();
            await AsyncFunc();
        }
        public async Task<string> AsyncFunc()
        {
            await Task.Run((() => { return "Hello"; }));
            return "abc";
        }

        async Task PrintAnswer()
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            Console.Out.WriteLine(answer);
        }
    }
}