using StudentAPI.Interface;
using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> students= new List<Student>();


        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            Student ?student= (from s in students
                             where s.Id == id
                             select s).SingleOrDefault();

            if(student != null )
                students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudentByID(int id)
        {
            Student? student = (from s in students
                                where s.Id == id
                                select s).SingleOrDefault();

            return student;
            
        }

        public List<Student> GetStudentByStandard_Section(string std, string section)
        {
            var sts= (from s in students
                     where s.Section == section && s.Std==std
                     select s).ToList();

            return sts;
        }

        public List<Student> GetStudentsByStandard(string std)
        {
            var selectedStudents= (from s in students
                                  where s.Std==std
                                  select s).ToList();
            return selectedStudents;
        }

        public Student UpdateStudent(Student student)
        {
            foreach(Student st in students)
            {
                if (st.Id == student.Id)
                {
                    st.Std=student.Std;
                    st.Section=student.Section;
                    st.Name =student.Name;
                }
            }
            return student;
        }
    }
}
