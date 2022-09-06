using System.Collections.Generic;
using System.Linq;

namespace MyCsharp.LINQ
{
    public class Lesson2
    {
        public static void Execut()
        {
            IEnumerable<int> lessThanTen = new[] {5, 12, 3}.Where(n => n < 10);
        }
    }
}