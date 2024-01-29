using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Student
    {
        public int id;
       public string name;
        public byte age;
        public char gender;
        public void Display()
        {
            Console.WriteLine($"ID:{id} Name:{name} Age:{age} Gender:{gender}");
        }
    }
}
