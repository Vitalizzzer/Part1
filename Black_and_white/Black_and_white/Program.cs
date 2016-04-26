using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_and_white
{
    class Program
    {
        static void Main()
        {           
            Whitelist white = new Whitelist(); // craete new class object for Whitelist;
            Blacklist black = new Blacklist(); // craete new class object for Blacklist;
            Blacklist_and_Whitelist black_white = new Blacklist_and_Whitelist(); // craete new class object for Blacklist_and_Whitelist;

            white.ReadFiles(); // execute a method from "Read" class in Whitelist class;
            black.ReadFiles(); // execute a method from "Read" class in Blacklist class;
            black_white.ReadFiles(); // execute a method from "Read" class in Blacklist_and_Whitelist class;
            
            // execute a method from each class;
            white.White();  
            black.Black();
            black_white.Black_and_White();
        }
    }
}
