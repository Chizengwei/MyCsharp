using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharp.Async
{
    public class CancelTest
    {
        private CancellationToken _token;
        private CancellationTokenSource _cancellationTokenSource;

        public async Task Foo(Action<int> action)
        {
            await Task.Run((() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 10 == 0) action(i / 10);
                }
            }));
        }
        async void ToDo()
        {
            await Foo((i => { Console.Out.WriteLine($"I={i}"); }));
        }
        public static void Execut()
        {
            CancelTest test = new CancelTest();
            test.ToDo();
        }
    }
}