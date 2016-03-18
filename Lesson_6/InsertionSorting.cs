using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    class InsertionSorting : BaseSort
    {
        public InsertionSorting(int[] array) : base (array)
        {  }
        
        public override void GeneralSort()
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
    }
}
