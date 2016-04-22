using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            HashSet<string> familyNames = new HashSet<string>();
            List<string> fullNames = new List<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            using (StreamReader readerNames = new StreamReader(@"C:\TEST\names.txt"))
            {
                string lineNames;
                while ((lineNames = readerNames.ReadLine()) != null)
                {
                    names.Add(lineNames);
                }
            }

            using (StreamReader readerFamilyNames = new StreamReader(@"C:\TEST\family_names.txt"))
            {
                string lineFamilyNames;
                while ((lineFamilyNames = readerFamilyNames.ReadLine()) != null)
                {
                    familyNames.Add(lineFamilyNames);
                }
            }
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach (string i in familyNames)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 0; i <= 25; i++)
            {
                System.Threading.Thread.Sleep(5);
                Random randomNames = new Random();
                string name = names.ElementAt(randomNames.Next(names.Count));

                System.Threading.Thread.Sleep(1);
                Random randomFamilyNames = new Random();
                string familyName = familyNames.ElementAt(randomFamilyNames.Next(familyNames.Count));
                System.Threading.Thread.Sleep(8);

                fullNames.Add(name + " " + familyName);
            }
            int count = dictionary.Count;
            foreach (string fullname in fullNames)
            {
                if (dictionary.ContainsKey(fullname))
                {
                    count++;
                }
                else
                {
                    dictionary.Add(fullname, count);
                    Console.WriteLine("Key: {0}, repeat {1} times", fullname, count);
                }
            }
            Console.ReadKey();
        }
    }
}
