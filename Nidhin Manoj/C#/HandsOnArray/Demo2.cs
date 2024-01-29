using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    internal class Demo2
    {
        static void Main()
        {
            int[] n = { 12, 23, 45, 56, 78, 23 };
            Console.WriteLine("size:" + n.Length);
            Console.WriteLine("dimension:" +n.Rank);
           Array.Sort(n);
         foreach (int i in n) Console.WriteLine(i);
            Console.WriteLine();
            Array.Reverse(n);
            foreach(int i in n) Console.WriteLine(i);
            if (Array.BinarySearch(n, 134) >= 0);
            else
            {
                Console.WriteLine("value exist");
            }
        }
    }
}
