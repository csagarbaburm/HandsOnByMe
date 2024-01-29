using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Collections
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            /* Employee details name and designation are entered by the user in random order.
               It is desired to maintain a list such that all the employees with the same designation 
               must be kept together. Also, the list must have Program Managers first, then Project Manager,
               Team Lead, Senior Programmer, and Junior Programmer in that order. Display the list after all entry is done */

            Dictionary<string, string> dict = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("1. Enter Details");
                Console.WriteLine("2. Exit");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 2) break;
                else
                {
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Designation:");
                    string desg = Console.ReadLine();
                    desg = desg.ToLower();
                    dict.Add(name, desg);
                }
            } while (true);

            string[] designationsOrder = { "Program Managers", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };

            Console.WriteLine("\nEmployees sorted by designation:");
            foreach (var k in designationsOrder)
            {
                string l = k.ToLower();
                if (dict.ContainsValue(l))
                {
                    foreach (var m in dict)
                    {
                        if (m.Value == l)
                        {
                            Console.WriteLine(m.Value + " " + m.Key);
                        }
                    }
                }
            }
        }
    }
}
