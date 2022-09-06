using System;
using NUnit.Framework;

namespace MyCsharp.MyTestCode
{
    public class ArrayDemo
    {
        static void WriteFirstValue(Array a)
        {
            Console.Out.WriteLine(a.Rank + "-dimensional");
            int[] indexer = new int[a.Rank];
            Console.Out.WriteLine("FirstValue is" + a.GetValue(indexer));
        }
        

        public static void Excute()
        {
            var bit = 0x1001;
            var alpha = 0x1110;
            var and = 0x1000;
            var or = 0x1111;
            Console.Out.WriteLine($"AND=:{bit & alpha}");
            Console.Out.WriteLine($"OR=:{alpha|bit}");
            Console.Out.WriteLine(and);
            Console.Out.WriteLine(or);
        }

        [Test]
        public void MyTestFunc()
        {
            Console.Out.WriteLine("HelloTest");
        }
    }
}