using System;


namespace VitaliiR
{
    abstract class Buffer<T> : IBuffer<T>
    {
        protected int size;
        protected T [] array;
        protected int pointer = 0;

        public Buffer(int size)
        {
            this.size = size;
            array = new T [size];
        }

        public T PushEnqueue(T item)
        {
            if (!IsFull())
            {
                Console.WriteLine("Insert element:{0}", item);
                array[pointer] = item;
                pointer++;
                return item;
            }
            else
            {
                Console.WriteLine("Stack/Queue is full!");
                return default(T);
            }
        }
        public abstract T PopDequeue();
        public abstract T Peek();
      
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
                Console.WriteLine("Content:");
                for (int i = 0; i < pointer; i++)
                {
                    Console.Write(" |{0}| \n", array[i]);
                }
            }
            else
            {
                Console.WriteLine("Stack/Queue is empty!");
            }
        }
    }
}
