using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{
    internal class Ques1
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 8, 9, 234, 567, 6789, 54, 234, 678, 789, 890, 34, 567, 789, 234, 66, 45, 47, 49, 55, 77, 78, 71 };

            var result = from num in nums
                         where num > 100 && num < 1000
                         select num * num * num;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



        }
    }
}

