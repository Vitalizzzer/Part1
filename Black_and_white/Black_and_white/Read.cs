using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Black_and_white
{
    public class Read
    {
        protected HashSet<string> input = new HashSet<string>(); // announce a new HashSet for input values;
        protected HashSet<string> blacklist = new HashSet<string>(); // announce a new HashSet for blacklist values;
        protected HashSet<string> whitelist = new HashSet<string>(); // announce a new HashSet for whitelist values;

          public void ReadFiles() // read values (strings) from each file and add it to each corresponding HashSet;
          {
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
          }

    }
}
