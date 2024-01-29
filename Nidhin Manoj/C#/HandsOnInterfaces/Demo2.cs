using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    class Student
    {
        //Automatic properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    interface IStudentRepository
    {
        Student GetById(int id);
        void Update(Student student);
        void DeleteById(int id);
        Student[] GetStudents();
    }
    class StudentRepository : IStudentRepository
    {
        public Student[] students = new Student[3];
        public void DeleteById(int id)
        {
        }

        public Student GetById(int id)
        {
            return students[id];
        }

        public Student[] GetStudents()
        {
            return students;
        }

        public void Update(Student student)
        {
        }
    }
    internal class Demo2
    {
        static void Main()
        {
            //write menu driven code to test StudentRepository functions
        }
    }
}
