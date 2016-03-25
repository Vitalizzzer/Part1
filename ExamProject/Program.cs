using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            //list.Remove(1);
            list.AddLast(3);
            //list.Remove(2);
            list.AddLast(4);
            list.AddLast(5);
            list.AddFirst(6);
            list.AddFirst(7);
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(10);            
            //list.Remove(6);
            //list.Remove(8);
            list.Print();            
            Console.ReadKey();
        }
    }
}
