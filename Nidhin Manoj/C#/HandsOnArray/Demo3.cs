using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    internal class Demo3
    {
        static void Main()
        {
            int [,] _2darray = new int[3, 2];
            _2darray[0, 0] = 28;
            _2darray[0, 1] = 98;
            _2darray[1, 0] = 68;
            _2darray[1, 1] = 48;
            _2darray[2, 0] = 98;
            _2darray[2, 1] = 95;
            foreach (int i in _2darray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("display the matrix format");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine( _2darray[i,j]+ "");
                }
                Console.WriteLine();
            }

        }
    }
}
