using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    class InsertionSorting
    {
        private int[]array;
        public InsertionSorting(int[] array)
        {
            this.array=array;            
        }
        
        public void InsertionSort()
         {
            for (int i = 0; i < array.Length - 1; i++)
             {
                 int j = i + 1;
                 while ((j > 0) && (array[j - 1] > array[j]))
                 {
                     Swap(ref array[j], ref array [j - 1]);
                     j--;
                 }
             }
        }
       
        public void Swap( ref int x,  ref int y)
        {
        int temp = x;
        x = y;
        y = temp;
        }
        
        public void Print()
        {
            Console.WriteLine("\nInsertion sorted:");
            foreach (int a in array)
            {
                Console.WriteLine("" + a);
            }            
        }  
    }
}
