using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques13
    {
        public static void Main(string[] args)
        {

            int[] nums = new int[5];
            int small;

            Console.WriteLine("Enter 5 numbers.....");

            for (int i = 0; i < 5; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            small = nums[0];

            for (int i = 0; i < 5; i++)
            {
                if (nums[i] < small)
                {
                    small = nums[i];
                }
            }

            Console.WriteLine($"The smallest number is: {small}");


        }

    }
}
