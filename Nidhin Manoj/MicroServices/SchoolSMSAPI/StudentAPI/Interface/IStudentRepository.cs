
using StudentAPI.Models;

namespace StudentAPI.Interface
{
    public interface IStudentRepository
    {


        void AddStudent(Student student);
        void DeleteStudent(int id);
        Student GetStudentByID(int id);
        Student UpdateStudent(Student student);
        List<Student> GetAll();
        List<Student> GetStudentsByStandard(string std);
        List<Student> GetStudentByStandard_Section(string std,string section);
    }
}
