using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_and_white
{
    public class Blacklist_and_Whitelist:Read
    {
        public void Black_and_White()
        {
            foreach (string inputItem in input) // loop for each input item;
            {
                bool isInBlackList = false;  // announce a new variable to be able to perform item verification in upper "foreach" loop;
                foreach (string blackItem in blacklist)  // loop for each Blacklist item;
                    {
                        if (inputItem.Contains(blackItem))  // executes when input item exists in Blacklist;
                            {
                                isInBlackList = true;
                                break;
                            } 
                    }

                if (!isInBlackList) // executes when input item is absent in Blacklist;
                    {
                        foreach (string whiteItem in whitelist) // loop for each Whitelist item;
                        {
                            if (inputItem.Contains(whiteItem))  // executes when input item exists in Whitelist and writes it to file;
                            {
                                using (StreamWriter outBlackWhite = new StreamWriter(@"C:\TEST\Output_Black_and_White.txt", true))
                                {
                                    outBlackWhite.WriteLine(inputItem);
                                }
                            }
                        }
                    } 
                }
            }
        }

 }
