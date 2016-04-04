using System;


namespace VitaliiR
{
    class MyStack<T>:DynamicArray<T>, IMyStack<T>
    {        
        public MyStack() : base()
        {  }
             
        public T PopDequeue()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("Pop top element:{0}", array[Size-1]);
                return array[--Size];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default (T);
            }
        }
        public T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Peek top element:{0}", array[Size-1]);
                return array[Size-1];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default (T);
            }
        }   
    }
}
