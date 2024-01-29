using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Teacher
    {
        private int teacherId;
        private string teacherName;
        private int age;
        
        public string NAME
        {
            get { return teacherName; }
            set {
                if (value != null)
                    teacherName = value;
                else
                {
                    Console.WriteLine("name should not be null or empty");
                    teacherName = "...";

                }
                    
                    }
        }
    public int ID
        {
            get { return teacherId; }
            set
            {
                if (value > 0)
                    teacherId = value;
                else
                    Console.WriteLine("invalid id");
            }

        }  

        public int AGE
        {
            get { return age; }
            set
            {


                if (value > 24 && value < 29)
                    age = value;
                else
                {
                    Console.WriteLine("not eligible for this post");
                    age = value;
                }
                    
            }
        }

    }


    class Test_Teacher
    {
        static void Main()
        {
            Teacher teacher = new Teacher();
            teacher.ID= -1;
            teacher.AGE= 23;
            teacher.NAME = null;
        Console.WriteLine($"ID:{teacher.ID} name:{teacher.NAME} age:{teacher.AGE} ");
            Teacher obj=new Teacher();
            obj.ID = 2;
            obj.AGE = 27;
            obj.NAME = "Nidhin";
            Console.WriteLine($"ID:{obj.ID} name:{obj.NAME} age:{obj.AGE}");
        }

    }

}
