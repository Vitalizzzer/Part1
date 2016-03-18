using System;


namespace VitaliiR
{
    class BubbleSorting<T> : Sorter<T> where T: IComparable<T>
    {
        
        public BubbleSorting(T[] array): base (array)
        { }
        
        public override void GeneralSort()
        {
        for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {                   
                    if (array[j].CompareTo (array[j+1])>0)
                    {
                      Swap (ref array[j], ref array[j+1]);                      
                    }                    
                  }                 
              }        
          }       
    }
}
