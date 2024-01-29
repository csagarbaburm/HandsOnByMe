using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques11
    {
        static void Main()
        {

            Console.WriteLine("The numbers divisible by 7 between 200 and 300 :");
            for (int i = 201; i < 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i + "");
                }

            }
        }
    }
}
