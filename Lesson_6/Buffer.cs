using System;


namespace VitaliiR
{
    class Buffer
    {
        protected int size = 0;
        protected int[] array;
        protected int pointer = 0;

        public Buffer(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public virtual void PushEnqueue(int item)
        {
            if (!IsFull())
            {
                Console.WriteLine("Insert element:{0}", item);
                array[pointer] = item;
                pointer++;
            }
            else
            {
                Console.WriteLine("Stack/Queue is full!");
            }
        }
        public virtual int PopDequeue()
        { return 0; }
            
        public bool IsFull()
        {
            if (pointer == size)
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
                Console.WriteLine("\nContent:");
                for (int i = 0; i < pointer; i++)
                {
                    Console.WriteLine("" + array[i]);
                }
            }
            else
            {
                Console.WriteLine("Stack/Queue is empty!");
            }
        }
    }
}
