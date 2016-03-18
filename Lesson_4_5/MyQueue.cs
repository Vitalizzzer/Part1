﻿using System;


namespace VitaliiR
{
    class MyQueue
    {
        private int queueSize = 0;
        private int[] array;
        private int pointer = 0;

        public MyQueue(int queueSize)
        {
            this.queueSize = queueSize;
            array = new int[queueSize];
        }

        public void Enqueue(int item)
        {
            if (!IsFull())
            {
                Console.WriteLine("Enqueue element:{0}", item);
                array[pointer] = item;
                pointer++;
            }
            else
            {
                Console.WriteLine("Queue is full!");
            }
        }
        public int Dequeue()
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
        public bool IsFull()
        {
            if (pointer == queueSize)
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
                Console.WriteLine("\nContent of queue:");
                for (int i = 0; i < pointer; i++)
                {
                    Console.WriteLine("" +array[i]);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty!");
            }
        }
    }
}
