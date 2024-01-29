using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Collections
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            /* Write an executable program in C# that will hold the employee code and employee names available in 
             an Organization using Collections.When the data is displayed it should be in a sorted manner.Choose an
 appropiate type of Collection.*/
            SortedList sl = new SortedList();
            sl.Add(100, "Alex");
            sl.Add(103, "Nidhin");
            sl.Add(102, "Fredy");
            sl.Add(104, "Steve");
            sl.Add(107, "Tony");

            foreach (var item in sl.Keys)
            {
                Console.WriteLine($"Emp_Id:{item} Name:{sl[item]}");
            }
        }
    }
}
