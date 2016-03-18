using System;


namespace VitaliiR
{
    class MyQueue<T>: Buffer<T>, IMyQueue<T>
    {
        
        public MyQueue(int size):base(size)
        {  }

        public override T PopDequeue()
        {
            if (!IsEmpty())
            {
                T item = array[0];
                for (int i = 0; i < pointer-1;i++)
                {
                    array[i] = array[i + 1];
                }
                    Console.WriteLine("Dequeue next element:{0}", item);
                    pointer--;
                    return item;
            }
            else
            {
                Console.WriteLine("Queue is empty!");
                return default (T);
            }
        }
        public override T Peek()
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
