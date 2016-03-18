using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            int i;
            int a;
            int b;
            for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if ((a == 0) && (b == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (b == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (a == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
