using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques17
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter 2 words.... ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("Both words are same...");
            }
            else
            {
                Console.WriteLine("Both words are not same...");
            }

        }

    }
}
