using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties_1
{
    internal class Student
    {
        private int id;
        private string name;
        private int[] marks = { 21, 453, 343, 535 };
        private int total;
        //create a property for id
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Marks
        {
            get
            {
                
                total = 0;
                foreach (int k in marks)
                {
                    total += k;
                }
                return total;
            }
        }

        public string Grade
        {
            get
            {
                if (total >= 700)
                    return "A++";
                else if (total >= 600)
                    return "A+";
                else if (total >= 500)
                    return "B";
                else
                    return "C";

            }
        }
    }

        class Test_Student
        {
            static void Main()
            {
                Student obj = new Student();
                obj.ID = 24324;
                obj.Name = "manoj";
            Console.WriteLine($"name:{obj.Name} id:{obj.ID} total:{obj.Marks} grade:{obj.Grade}");
            }
        }
    
}

