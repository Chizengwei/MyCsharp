using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace MyCsharp.LINQ
{
    public class Lesson1
    {
        private string[] names = {"Tao", "Dai", "Harry", "Mari", "Jay", "China", "Linq"};

        public void Exe()
        {
            var query = names
                    .Where(n => n.Contains('a'))
                    .OrderBy(n => n.Length)
                    .Select(n => n.ToUpper())
                ;
            foreach (var VARIABLE in query)
            {
                Console.Out.WriteLine($"query=:{VARIABLE}");
            }

            var query1 = from n in names
                where n.Contains('a')
                orderby n.Length
                select n.ToUpper();

            foreach (var varable in query1)
            {
                Console.Out.WriteLine($"query1={varable}");
            }

            int[] intArr = {1, 3, 4, 5, 6, 1};
            int[] intArr1 = {2, 5, 6, 8, 10, 23, 4};
            List<int> list = new List<int> {1, 2, 4};
            string[] stringArr = {"Add", "Sub", "Multiply"};
            var ret = intArr.Union(intArr1);

            var numbers = list
                    .Select(n => n * 10)
                    .ToArray()
                ;
            list.Add(30);
            foreach (var VARIABLE in numbers)
            {
                Console.Out.WriteLine($"num={VARIABLE}|");
            }

            list.Clear();
            foreach (var c in numbers)
                Console.Out.WriteLine(c + "|");
        }

        public static void Execut()
        {
            IEnumerable<char> query = "Not what you might expect";
            string ow = "aeiou";

            foreach (var VARIABLE in ow)
            {
                query = query.Where(c => c != VARIABLE);
            }
            foreach (var VARIABLE in query)
            {
                Console.Out.Write(VARIABLE);
            }
        }
    }
}