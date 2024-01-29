using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo1
    {
        private int a;
        public void Message()
        {
            Console.WriteLine("hello");
            Console.WriteLine("A=" + a);
        }
        public void Seta()
        {
            a = 10;
        }
        public void Greet(string name)
        {
            Console.WriteLine("hello " + name); ;
        }
        public void Add(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }
    }
    class Test_Demo1
    {
   static void Main()
        {
            Demo1 d1= new Demo1();
            d1.Message();
            d1.Seta();
            d1.Message();
            d1.Greet("Sachu");
            d1.Greet("Viraaa");
            d1.Add(33, 55);

        }
    }
}

