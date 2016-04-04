using System;


namespace VitaliiR
{
    class MyQueue<T>: DynamicArray<T>, IMyQueue<T>
    {
        
        public MyQueue():base()
        {  }

        public T PopDequeue()
         {           
          
          if (!IsEmpty())
            {
                T value = array[0];
                for (int i = 0; i < Size-1; i++)
                {
                    array[i] = array[i + 1];                 
                }
                size--;
                return value;
                
            }
          else
          {
              Console.WriteLine("Queue is empty!");
              return default(T);
          }
          
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Peek next element:{0}", array[0]);
                return array[0];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
        }   
    }
}
