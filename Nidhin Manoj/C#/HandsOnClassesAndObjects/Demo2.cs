using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo2
    {
        public int Sum(params int[]a)
        {
            int result = 0;
            foreach (int i in a) 
            {
            result += i;
            }
            return result;
        }
        public string[] Flowers()
        {
            string[] flowers = { "rose", "lilly", "jasmine", "lotus" };
            return flowers;
        }
        static void Main()
        {
            Demo2 demo = new Demo2();
            int r= demo.Sum(new int[] { 1, 2, 3 });
            Console.WriteLine(r);
            int[] n = { 23, 34, 56, 76, 45 };
            r= demo.Sum(n);
            Console.WriteLine(r);
            string[]result=demo.Flowers();
            foreach (string s in result) 
                Console.WriteLine(s);
            r= demo.Sum(34,54,67,33,22);
            
        }
    }
}
