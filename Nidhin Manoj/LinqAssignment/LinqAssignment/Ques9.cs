using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{
    internal class Ques9
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 34, 56, 54, 4, 23, 54, 67, 78, 567, 78, 5453, 657, 54, 2365, 59, 567 };

            var arr = nums.Where(i => i % 2 == 0);
            Console.WriteLine("Count of even numbers: " + nums.Where(i => i % 2 == 0).Count());

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
