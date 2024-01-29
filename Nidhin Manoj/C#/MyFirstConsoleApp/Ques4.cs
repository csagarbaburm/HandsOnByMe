using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class odd_even
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int a= int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
                Console.WriteLine("the given number is even");
            else
            {
                Console.WriteLine("the given number is odd");
            }
        }
    }
}
