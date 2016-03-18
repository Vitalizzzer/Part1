using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        static void Main()
        {

            Console.WriteLine("Please enter an array size and press ENTER to continue");
            int size = Convert.ToInt32(Console.ReadLine());     //Converts entered data (array length) to "int";
            int i;
            int[] Array = new int[size];        //Allocate the array;
            for (i = 0; i < Array.Length; i++)  //loop which continues till the end of array length;
            {
                Console.WriteLine("Please enter a value and press ENTER");
                int value = Convert.ToInt32(Console.ReadLine());    //Converts entered data (array value) to "int";
                Array[i] = value;  //assign enered values to the array;
            }

            Console.WriteLine("Maximum value in this array: {0}", Array.Max()); // Show maximum value in this array;
            Console.WriteLine("Minimum value in this array: {0}", Array.Min()); // Show minimum value in this array;
            Console.ReadKey();
        }

    }
}
