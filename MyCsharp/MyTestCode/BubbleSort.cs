using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MyCsharp.MyTestCode
{
    class MyClass :Collection<object>
    {
        
    }
    public class BubbleSort
    {
        public static void Excute()
        {
            int[] source = new[] {20, 988, 19992, 11, 22, 3, 124, 1145,09877,2323,556,232,66,0993994,34335,66464535};
            for (int i = 0; i < source.Length-1; i++)
            {
                for (int j = 0; j < source.Length-1-i; j++)
                {
                    if (source[j]>source[j+1])
                    {
                        int temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }

            Console.Out.WriteLine(source[0]);
            Console.Out.WriteLine(source[source.Length-1]);
            MessageBox.Show(source.Length+"");
        }
    }
}