using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    class InsertionSorting<T> : Sorter<T> where T: IComparable<T>
    {
        public InsertionSorting(T[] array) : base (array)
        { }
        
        public override void GeneralSort()
         {
            for (int i = 0; i < array.Length-1; i++)
             {
                 int j = i + 1;
                 while ((j > 0) && array[j].CompareTo (array[j - 1]) < 0)
                 {
                     Swap(ref array[j], ref array [j - 1]);
                     
                 }
             }
        }       
    }
}
