using System;


namespace VitaliiR
{
    class BaseSort
    {
        protected int[] array;
        public BaseSort(int[] array)
        {
            this.array = array;
        }

        public virtual void GeneralSort()
        {  }

        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Print()
        {
            Console.WriteLine("Sorted:\t");
            foreach (int a in array)
            {
                Console.WriteLine("" + a);
            }
        }
    }
}
