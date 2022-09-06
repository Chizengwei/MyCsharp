using System;
using System.Collections.Generic;

namespace MyCsharp.MyTestCode
{
    public class ListTest
    {
        public static void Execut()
        {
            List<string> list = new List<string>();
            list.Add("b");
            list.Add("a");
            list.Add("c");
            list.Add("d");
            list.Add("b");
            Console.Out.WriteLine(list[1]);
            if (list.Contains("c") && list.Contains("b"))
            {
                Console.Out.WriteLine("集合包含元素C");
            }
        }
    }
}