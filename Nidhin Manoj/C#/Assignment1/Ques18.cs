using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques18
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a word.... ");
            string str1 = Console.ReadLine();
            bool flag = true;


            for (int i = 0; i < str1.Length / 2; i++)
            {
                if (str1[i] != str1[str1.Length - 1 - i])
                {
                    flag = false;
                    break;
                }

            }
            if (flag)
            {
                Console.Write("This is palindrome...");
            }
            else
            {
                Console.Write("This is not palindrome...");
            }


        }
    }
}
