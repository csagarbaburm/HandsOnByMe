using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class StringInterpolation
    {
        static void Main()
        {
            Console.WriteLine("enter the name");
           string employeename= Console.ReadLine();
            Console.WriteLine("enter employee id");
            int employeeid= int.Parse(Console.ReadLine());
            Console.WriteLine("enter gender");
            char gender=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the designation");
            string designation= Console.ReadLine();
            Console.WriteLine("enter the salary");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EMPLOYEE DETAILS");
            Console.WriteLine($"Name:{employeename} id:{employeeid} gender:{gender} designation:{designation} salary:{salary}");
        }
    }
}
