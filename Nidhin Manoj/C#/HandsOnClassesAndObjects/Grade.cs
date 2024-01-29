using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Grade
    {
        public static int[] marks;
        public static int total;
        public static int Total()
        {
            int totl = 0;
            foreach(int k in marks)
            {
                totl += k;
            }
            total = totl;
            return totl;
        }
        public static string Rank()
        {
            if (total >= 700)
                return "A+";
            else if (total >= 600)
                return "A";
            else
                return "B"; 
        }
    }
    class Test_Grade
    {
        static void Main()
        {
            Grade.marks = new int[] { 45, 23, 45, 67, 32, 23 };
       Console.WriteLine($"Total:{Grade.Total()} Grade:{Grade.Rank()}");

        }
    }
}
