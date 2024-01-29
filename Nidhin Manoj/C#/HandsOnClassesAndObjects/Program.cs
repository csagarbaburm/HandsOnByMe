using System.Reflection;
using System.Xml.Linq;

namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student obj= new Student();
            obj.gender = 'M';
            obj.age = 10;
            obj.name = "Nidhin";
            obj.id = 1;
            obj.Display();
            Student s1 = new Student();
            s1.gender = 'M';
            s1.age = 11;
            s1.name = "Nevin";
            s1.id = 2;
            s1.Display();
            Student s2 = new Student()
            {
                name = "sagar",
                id = 3,
                gender = 'M',
                age = 10,
               

           };
            s2.Display();
            //Student s4 = null;
            //s4.name = "sanal";
            //s4.id = 4;
            //s4.Display();
            Student[] students = new Student[3];
            students[0] = new Student()
            {
                name = "amal",
                age = 10,
                gender = 'M',
                id = 88
            };
            students[1] = new Student()
            {
                name = "amala",
                age = 10,
                gender = 'F',
                id = 88
            };
            students[2] = new Student()
            {
                name = "amalU",
                age = 10,
                gender = 'F',
                id = 8

            };
            students[2].Display();

            foreach (Student s in students)
            {
                s.Display();
            }
            for(int i=0; i < 3;i++)
            {
                students[i].Display();
            }

        }
    }
}

