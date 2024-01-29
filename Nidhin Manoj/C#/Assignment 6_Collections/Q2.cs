using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Collections
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            // Write an Arraylist that will hold the names of all students and display them in descending order
            ArrayList list = new ArrayList();
            list.Add("Akhil");
            list.Add("Amal");
            list.Add("Alen");
            list.Add("Stefin");
            list.Add("Edwin");

            list.Sort();
            list.Reverse();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
