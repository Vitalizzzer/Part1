using System;

namespace VitaliiR
{
    
   class Sorter
    {
        int[]array;
        public Sorter(int[] array)
        {
            this.array=array;            
        }
        
        public virtual void BubbleSort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j <= array.Length - 1; j++)
                {
                    if (array[j] > array[i + 1])
                    {
                        Swap(ref array[j], ref array[i + 1]);
                    }
                }
            }
        }

        public virtual void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public virtual void Print()
        {
            Console.WriteLine("Bubble sorted:\t");
            foreach (int a in array)
            {
                Console.WriteLine("" + a);
            }
        } 
    }
}
