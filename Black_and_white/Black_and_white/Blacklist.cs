using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_and_white
{
    public class Blacklist:Read
    {
        public void Black()
        {
            foreach (string inputItem in input) // loop for each input item;
            {
                bool isInBlackList = false; // announce a new variable to be able to perform item verification in upper "foreach" loop;
                foreach (string blackItem in blacklist)  // loop for each Blacklist item;
                {
                    if (inputItem.Contains(blackItem))  // executes when input item exists in Blacklist;
                    {
                        isInBlackList = true;
                        break;
                    } 
                }

                if (!isInBlackList) // executes when input item is absent in Blacklist and writes it to file;
                { 
                    using (StreamWriter outBlack = new StreamWriter(@"C:\TEST\Output_Blacklist.txt", true))
                        {
                            outBlack.WriteLine(inputItem);
                        }
                }
            }
        }
    }
}
