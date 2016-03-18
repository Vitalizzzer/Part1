using System;


namespace VitaliiR
{
    class BubbleSorting
    {
        int[]array;
        public BubbleSorting(int[] array)
        {
            this.array=array;            
        }
        
        public void BubbleSort()
        {
        for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j <= array.Length - 1; j++)
                {
                    if (array[j] > array[i+1])
                    {
                      Swap (ref array[j], ref array[i+1]);                      
                    }                    
                  }                 
              }        
          }         
        
        public void Swap(ref int x, ref int y)
        {
        int temp = x;
        x = y;
        y = temp;
        }

        public void Print()
        {
            Console.WriteLine("Bubble sorted:\t");
          foreach (int a in array)
            {
                Console.WriteLine("" +a);                
            }           
        }  
    }
}
