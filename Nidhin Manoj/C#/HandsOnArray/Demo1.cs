using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    internal class Demo1
    {
        static void Main()
        {
            string[] students = new string[5] { "abiya", "arya", "adithya", "faris", "alfia" };
            Console.WriteLine("enter the student name");
            bool flag = false;
            string name = Console.ReadLine();
            foreach (string s in students)
            {
                if (s == name)
                {
                    flag = true;
                    break;
                }
            }
                if (flag)
                {
                    Console.WriteLine($"{name} is selected for test");
                }
                else
                {
                    Console.WriteLine($"{name} is not selected for test");
                }
            
        }
    }
}
