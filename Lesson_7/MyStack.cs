using System;


namespace VitaliiR
{
    class MyStack<T>:Buffer<T>, IMyStack<T>
    {        
        public MyStack(int size) : base(size)
        {  }
             
        public override T PopDequeue()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("Pop top element:{0}", array[pointer-1]);
                return array[--pointer];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default (T);
            }
        }
        public override T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Peek top element:{0}", array[pointer-1]);
                return array[pointer-1];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default (T);
            }
        }   
    }
}
