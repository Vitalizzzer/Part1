using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_and_white
{
    public class Whitelist:Read
    {    
        public void White()
        {

            foreach (string inputItem in input) // loop for each input item;
            {                
                foreach (string whiteItem in whitelist) // loop for each Whitelist item;
                {
                    if (inputItem.Contains(whiteItem)) // executes when input item exists in Whitelist and writes it to file;
                    {
                        using (StreamWriter outWhite = new StreamWriter(@"C:\TEST\Output_Whitelist.txt", true))
                        {
                            outWhite.WriteLine(inputItem);                            
                        }
                    }                            
                }                
            }
        }
    }
}
