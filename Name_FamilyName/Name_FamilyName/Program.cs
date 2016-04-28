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
        static void Main(string[] args)
        {

            HashSet<string> input = new HashSet<string>();
            HashSet<string> blacklist = new HashSet<string>();
            HashSet<string> whitelist = new HashSet<string>();

            using (StreamReader readInput = new StreamReader(@"C:\TEST\Input.txt"))
            {
                string lineInput;
                while ((lineInput = readInput.ReadLine()) != null)
                {
                    input.Add(lineInput);
                }
            }


            using (StreamReader readBlacklist = new StreamReader(@"C:\TEST\Blacklist.txt"))
            {
                string lineBlacklist;
                while ((lineBlacklist = readBlacklist.ReadLine()) != null)
                {
                    blacklist.Add(lineBlacklist);
                }
            }


            using (StreamReader readWhitelist = new StreamReader(@"C:\TEST\Whitelist.txt"))
            {
                string lineWhitelist;
                while ((lineWhitelist = readWhitelist.ReadLine()) != null)
                {
                    whitelist.Add(lineWhitelist);
                }
            }


            foreach (string inputItem in input)
            {
                foreach (string blackItem in blacklist)
                {
                    if (inputItem != blackItem)
                    {
                        using (StreamWriter output = new StreamWriter(@"C:\TEST\Output_Blacklist.txt", true))
                        {
                            output.WriteLine(inputItem);
                        }
                    }
                }
            }

            //foreach (string inputItem in input)
            //{
            //    foreach (string whiteItem in whitelist)
            //    {
            //        if (inputItem.Equals(whiteItem))
            //        {
            //            using (StreamWriter output = new StreamWriter(@"C:\TEST\Output_Whitelist.txt", true))
            //            {
            //                output.WriteLine(inputItem);
            //            }
            //        }
            //    }
            //}

            //foreach (string inputItem in input)
            //{
            //    foreach (string blackItem in blacklist)
            //    {
            //        foreach (string whiteItem in whitelist)
            //        {
            //            if (!inputItem.Equals(blackItem) && inputItem.Equals(whiteItem))
            //            {
            //                using (StreamWriter output = new StreamWriter(@"C:\TEST\Output_Black_White.txt", true))
            //                {
            //                    output.WriteLine(inputItem);
            //                }
            //            }
            //        }
            //    }
            //}

        }
    }
}
