using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques16
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a word: ");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

        }

    }
}
