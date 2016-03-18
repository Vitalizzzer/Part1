using System;


namespace VitaliiR
{
    abstract class Sorter<T>:ISorter<T>
    {
        protected T[] array;
        public Sorter(T[] array)
        {
            this.array = array;
        }

        public abstract void GeneralSort();
        
        public void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public void Print()
        {
            Console.WriteLine("Sorted:\t");
            foreach (T a in array)
            {
                Console.WriteLine("" + a);
            }
        }
    }
}
