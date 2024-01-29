using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques5
    {
        static void Main()
        {
            int a, odd = 0, even = 0;
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("even numbers are " + even + " and odd numbers are " + odd);



        }
    }
}
