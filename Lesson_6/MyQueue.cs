﻿using System;


namespace VitaliiR
{
    class MyQueue: Buffer
    {
        
        public MyQueue(int size):base(size)
        {  }

        public override int PopDequeue()
        {
            if (!IsEmpty())
            {
                int item = array[0];
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
                return 0;
            }
        } 
    }
}
