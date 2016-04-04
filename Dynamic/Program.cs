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
           // int[] array = { 8, 34, 1, 76, 45, 23, 90 };

            // Crete stack   
            Console.WriteLine("\n-----------MyStack-----------");
            MyStack<string> Stack1 = new MyStack<string>();
            Stack1.Add("Hello");
            Stack1.Add("Good Morning");
            Stack1.Add("Enjoy");
            Stack1.Add("Relax");
            Stack1.Add("Take it easy");
            Stack1.Add("Bye");
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
            MyQueue <int> Queue1 = new MyQueue<int>();
            Queue1.Add(87);
            Queue1.Add(23);
            Queue1.Add(33);
            Queue1.Add(99);
            Queue1.Peek();
            Queue1.Print();
            Queue1.Peek();
            Queue1.PopDequeue();
            Queue1.Add(22);
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
