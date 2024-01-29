using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques12
    {
        static void Main()
        {
            Console.WriteLine("enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " is largest number");
                }
                else
                {
                    Console.WriteLine(c + " is largest number");
                }

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " is largest number");
                }
                else
                {
                    Console.WriteLine(c + " is the largest number");
                }
            }
        }
    }
}
