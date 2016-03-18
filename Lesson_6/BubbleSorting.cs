using System;


namespace VitaliiR
{
    class BubbleSorting : BaseSort
    {
        
        public BubbleSorting(int[] array): base (array)
        { }
        
        public override void GeneralSort()
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
    }
}
