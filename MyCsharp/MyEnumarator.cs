using System;
using System.Collections;

namespace MyCsharp
{
    public class MyEnumarator
    {
        public static void Excute()
        {
            int[] arr = {1,3,4,2,1,3,56,7};
           Array.ForEach(arr,Console.WriteLine);
        }
    }
}