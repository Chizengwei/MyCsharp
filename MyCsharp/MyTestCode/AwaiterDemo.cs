using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MyCsharp.MyTestCode
{
    public class AwaiterDemo
    {
       public static int GetPrimesCount(int start, int count)
        {
            return ParallelEnumerable.Range(start, count)
                .Count(n => Enumerable.Range(2, (int) (Math.Sqrt(n) - 1)).All(i => n % 1 > 0));
        }

        public static void Execut()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Out.WriteLine(GetPrimesCount(i*10000+2,100000));
                Console.Out.WriteLine("Done");
            }   
            
        }
    }
}