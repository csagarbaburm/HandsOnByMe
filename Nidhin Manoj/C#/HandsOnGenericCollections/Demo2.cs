using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo2
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(45);
            list.Add(50);
            int k = list[2];
            Console.WriteLine("count"+list.Count);
            list.Remove(10);
            list.Sort();
            list.Reverse();
            foreach(var i in list)
                Console.WriteLine(i);
        }
    }
}
