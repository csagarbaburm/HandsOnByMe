 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnStrings
{
    internal class Demo1
    {
        static void Main()
        {
            StringBuilder obj= new StringBuilder();
            obj.AppendLine("good morning");
            Console.WriteLine(obj);
            obj.Replace("morning", "evening");
            Console.WriteLine(obj);
            string s = "good morning";
            Console.WriteLine(s);
            s.Replace("morning", "evening");
            Console.WriteLine(s);
        }
    }
}
