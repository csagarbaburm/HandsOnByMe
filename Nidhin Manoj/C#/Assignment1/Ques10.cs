using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques10
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} x {n}: {i * n}");
            }


        }
    }
}
