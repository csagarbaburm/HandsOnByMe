using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace HandsOnConstructorsAndProperties
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string school;
        public static string city;
        //default constructor
    public Student()
        {
            school = "DPS";
        }
        //parameter constructor
        public Student(string fname, string lname,string s)
        {
            firstName=fname;
            lastName=lname;
            school = s;
        }
        static Student()
        {
            city = "kochi";
        }
        public void Display()
        {
            Console.WriteLine($"Name:{firstName} {lastName} school:{school} city:{city}");
         
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student s1= new Student();
            s1.firstName = "arun";
            s1.lastName = "shetty";
            s1.Display();
            Student s2= new Student("nidhin", "manoj","ABC");
            s2.Display();

        }
    }
}
