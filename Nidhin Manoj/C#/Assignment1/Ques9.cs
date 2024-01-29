using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Ques9
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 0;

            Console.WriteLine(n1);

            Console.WriteLine(n2);

            while (true)
            {

                n3 = n1 + n2;
                if (n3 < 40)
                {
                    Console.WriteLine(n3);
                }
                else
                {
                    break;
                }

                n1 = n2;
                n2 = n3;
            }

        }

    }
}
