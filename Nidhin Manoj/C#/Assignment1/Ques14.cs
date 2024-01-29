using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques14
    {
        public static void Main(string[] args)
        {

            float[] nums = new float[10];
            float total = 0.0f, avg, max, min;

            Console.WriteLine("Enter 10 marks....");

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            foreach (float j in nums)
            {
                total += j;
            }

            avg = total / 10.0f;
            max = nums.Max();
            min = nums.Min();

            Console.WriteLine($"Total marks:{total} ");
            Console.WriteLine($"Average Marks:{avg} ");
            Console.WriteLine($"Maximum Marks:{max} ");
            Console.WriteLine($"Minimum marks:{min} ");


        }

    }
}
