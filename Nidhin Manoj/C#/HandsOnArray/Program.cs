using System.Numerics;

namespace HandsOnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total=0;
            Console.WriteLine("Hello, World!");
            int[] marks = new int[6];
            marks[0] = 12;
            marks[1] = 23;
            marks[2] = 34;
            marks[4] = 56;
            marks[5] = 87;
            Console.WriteLine("ENGLISH MARKS:" + marks[4]);
            Console.WriteLine("TOTAL MARKS:");
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(marks[i]);
              total = total + marks[i];
            }
            Console.WriteLine("total marks:" + total);

            foreach(int k in marks)
            {
                Console.WriteLine(k);
            }


        }
    }
}
