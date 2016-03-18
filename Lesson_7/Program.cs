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
            int[] array = { 8, 34, 1, 76, 45, 23, 90 };
            Console.WriteLine("\n-----------Bubble Sorting-----------");
            // Bubble sorting
            BubbleSorting<int> Sort1 = new BubbleSorting<int>(array);
            Sort1.GeneralSort();
            Sort1.Print();
               
            Console.WriteLine("\n-----------Insertion Sorting-----------");
            // Insertion sorting
            InsertionSorting<int> Sort3 = new InsertionSorting<int>(array);
            Sort3.GeneralSort();
            Sort3.Print();
            
            // Crete stack   
            Console.WriteLine("\n-----------MyStack-----------");
            MyStack<string> Stack1 = new MyStack<string>(3);
            Stack1.PushEnqueue("Hello");
            Stack1.PushEnqueue("Good Morning");
            Stack1.PushEnqueue("Enjoy");
            Stack1.PushEnqueue("Relax");
            Stack1.Print();
            Stack1.Peek();
            Stack1.PopDequeue();
            Stack1.Peek();
            Stack1.PopDequeue();
            Stack1.Peek();
            Stack1.PopDequeue();           
            Stack1.Print();           

            // Crete queue  
            Console.WriteLine("\n-----------MyQueue-----------");
            MyQueue <int> Queue1 = new MyQueue<int>(3);
            Queue1.PushEnqueue(87);
            Queue1.PushEnqueue(23);
            Queue1.PushEnqueue(33);
            Queue1.PushEnqueue(99);
            Queue1.Peek();
            Queue1.Print();
            Queue1.Peek();
            Queue1.PopDequeue();            
            Queue1.PushEnqueue(22);
            Queue1.Print();
            Queue1.Peek();
            Queue1.PopDequeue();
            Queue1.Print();
            Queue1.Peek();
            Queue1.PopDequeue();
            Queue1.PopDequeue();
            Queue1.PopDequeue(); 
            Console.ReadKey();            
        }
    }
}
