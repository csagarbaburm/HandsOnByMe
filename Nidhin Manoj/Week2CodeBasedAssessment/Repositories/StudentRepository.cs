using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.IO;
using Week2CodeBasedAssessment.Model;

namespace Week2CodeBasedAssessment.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> students = new List<Student>();


        public void AddStudent(Student student)
        {
            try
            {
                student.StudentId = new Random().Next(1000, 9999);
                students.Add(student);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.StudentId.Equals(id))
                        students.Remove(student);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public Student FindStudentByID(int id)
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.StudentId.Equals(id))
                        return student;
                }
                return null;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<Student> GetAllStudentsByQualification(string qualification)
        {
            try
            {
                List<Student> selectedStudents = new List<Student>();

                foreach (Student student in students)
                {
                    if (student.qualification == qualification)
                        selectedStudents.Add(student);
                }
                return selectedStudents;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public List<Student> GetAllStudentsBySkill(string skill)
        {
            try
            {
                List<Student> selectedStudents = new List<Student>();

                foreach (Student student in students)
                {
                    if (student.skills == skill)
                        selectedStudents.Add(student);
                }
                return selectedStudents;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void UpdateStudentQualification(int id, string qualification)
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.StudentId.Equals(id))
                        student.qualification = qualification;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateStudentSkill(int id, string skill)
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.StudentId.Equals(id))
                        student.skills = skill;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}