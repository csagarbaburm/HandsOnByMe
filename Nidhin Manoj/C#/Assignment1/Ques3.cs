using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("the numbers between are:");
            for (int i = a + 1; i < b; i++)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
