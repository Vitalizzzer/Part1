using System;


namespace VitaliiR
{
    class MyStack:Buffer
    {        
        public MyStack(int size) : base(size)
        {  }
             
        public override int PopDequeue()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("Pop top element:{0}", array[pointer-1]);
                return array[--pointer];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }
        public int Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Peek top element:{0}", array[pointer - 1]);
                return array[pointer-1];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }  
    }
}
