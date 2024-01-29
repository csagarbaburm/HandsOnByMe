using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques8
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;

            }
            Console.WriteLine($"Factorial of {n} is: {fact}");

        }

    }
}
