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
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("first_one");
            list.AddLast("last_two");            
            list.AddLast("last_three");           
            list.AddLast("last_four");
            list.AddFirst("zero");
            list.AddLast("last_five");           
            list.Print();          
            list.Remove("last_five");                 
            list.Print();            
            Console.ReadKey();
        }
    }
}
