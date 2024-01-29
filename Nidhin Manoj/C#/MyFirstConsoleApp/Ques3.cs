using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Accept_two_numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
             int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
           int b =int.Parse(Console.ReadLine());
            Console.WriteLine("the numbers between are:");
            for (int i=a+1;i<b;i++)
            {
                Console.WriteLine(i+" ");
            }
             
        }

    }
}
