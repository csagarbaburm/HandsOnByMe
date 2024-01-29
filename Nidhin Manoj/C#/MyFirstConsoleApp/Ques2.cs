using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class User_welcome
    {
        static void Main()
        {
            Console.WriteLine("enter the username");
           string name = Console.ReadLine();
            Console.WriteLine("Hi!" + name + " Welcome to the world of C#");

        }
    }
}
