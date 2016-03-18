using System;

namespace Divider
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            a = 4;
            b = 2;
            if (a % b == 0)
            {
                Console.WriteLine("{0} is a divider of {1}", b, a);
                Console.WriteLine("Press your favourite key to close this window");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{0} is not a divider of {1}", b, a);
                Console.WriteLine("Press your favourite key to close this window");
                Console.ReadKey();
            }

        }
    }
}