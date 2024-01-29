using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Collections
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public int std;
        public char section;

    }
    internal class Q5
    {
        static void Main(string[] args)
        {
            /* Create a class with name student and store all the student details in an ArrayList and Display the
             Details.*/
            Student s = new Student() { id = 101, name = "Aromal", age = 21, std = 12, section = 'A' };
            Student s1 = new Student() { id = 102, name = "Alan", age = 22, std = 11, section = 'B' };
            Student s2 = new Student() { id = 103, name = "Aron", age = 20, std = 10, section = 'C' };
            Student s3 = new Student() { id = 104, name = "Nidhin", age = 18, std = 9, section = 'D' };

            ArrayList al = new ArrayList();
            al.Add(s);
            al.Add(s1);
            al.Add(s2);
            al.Add(s3);

            foreach (Student i in al)
            {
                Console.WriteLine($"Id:{i.id} Name:{i.name} Age:{i.age} Std:{i.std} Section:{i.section}");
            }
        }
    }
}
