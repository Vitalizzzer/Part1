using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] array={8,34,1,76,45,23,90};
            Console.WriteLine("\n-----------Sorting-----------");
            // Bubble sorting
            BubbleSorting Sort1 = new BubbleSorting(array);
            Sort1.BubbleSort();
            Sort1.Print();
           
            // Insertion sorting
            InsertionSorting Sort2 = new InsertionSorting(array);
            Sort2.InsertionSort();
            Sort2.Print();
            
            // Crete stack   
            Console.WriteLine("\n-----------MyStack-----------");
            MyStack Stack1 = new MyStack(3);
            Stack1.Push(5);
            Stack1.Push(7);
            Stack1.Push(3);
            Stack1.Push(4);
            Stack1.Print();
            Stack1.Peek();
            Stack1.Pop();
            Stack1.Peek();
            Stack1.Pop();
            Stack1.Peek();
            Stack1.Pop();           
            Stack1.Print();           

            // Crete queue  
            Console.WriteLine("\n-----------MyQueue-----------");
            MyQueue Queue1 = new MyQueue(3);
            Queue1.Enqueue(87);
            Queue1.Enqueue(23);
            Queue1.Enqueue(33);
            Queue1.Enqueue(99);
            Queue1.Print();            
            Queue1.Dequeue();            
            Queue1.Enqueue(22);
            Queue1.Print();            
            Queue1.Dequeue();
            Queue1.Print();
            Queue1.Dequeue();
            Queue1.Dequeue();
            Queue1.Dequeue(); 
            Console.ReadKey();
        }
    }
}
