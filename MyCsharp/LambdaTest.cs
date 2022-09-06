using System;

namespace MyCsharp
{
    public class LambdaTest
    {
        public static void Execut()
        {
            var c = Nat();
            Console.Out.WriteLine(c());
            Console.Out.WriteLine(c());
            Console.Out.WriteLine(Nat()());//重新执行一次函数
        }

        static Func<int> Nat()
        {
            int seed = 0;
            return () => seed++;//返回一个闭包
        }
    }
}