using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques6
    {
        static void Main()
        {
            Console.WriteLine("enter the temperature in fahrenheit");
            double F=double.Parse(Console.ReadLine());
            double c = (F - 32.0) * (5.0 / 9.0);
            Console.WriteLine("temperature in celsius is :"+ c);
        }
    }
}
