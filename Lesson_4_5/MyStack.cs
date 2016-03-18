using System;


namespace VitaliiR
{
    class MyStack
    {
        private int stackSize = 0;
        private int [] array;
        private int pointer= 0;
        
        public MyStack(int stackSize)
        {
            this.stackSize = stackSize;
            array = new int [stackSize];
        }
        
        public void Push(int item)
        {
            if(!IsFull())
            {
                Console.WriteLine("Push element:{0}", item);
                array[pointer]=item;
                pointer++;
            }
            else
            {
                Console.WriteLine("Stack is full!");
            }
        }
        public int Pop()
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
        public bool IsFull()
        {
            if(pointer==stackSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmpty()
        {
            if (pointer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("\nContent of stack:");
                for (int i = 0; i < pointer; i++)
                {                    
                    Console.WriteLine(""+array[i]);
                }
            }
            else
            {
                Console.WriteLine("Stack is empty!");
            }
        }
    }
}
