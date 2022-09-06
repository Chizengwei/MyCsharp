using System;

namespace MyCsharp
{
    public class BlankAcount
    {
        public static bool Counter(int sum)
        {
            int count = 0;
            count++;
            count += sum * 3;
            count *= sum;
            Console.Out.WriteLine($"count=:{count}");
            if (count >= 20)
            {
                return true;
            }

            return false;
        }

        public static void Excute()
        {
            int input = 10;
            input *= 20;
            Counter(input);
        }
    }
}