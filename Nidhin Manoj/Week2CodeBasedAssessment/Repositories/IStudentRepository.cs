using Week2CodeBasedAssessment.Model;

namespace Week2CodeBasedAssessment.Repositories
{
    public interface IStudentRepository
    {
        Student FindStudentByID(int id);
        void AddStudent(Student student);
        void UpdateStudentSkill(int id, string skill);
        void UpdateStudentQualification(int id, string qualification);
        void DeleteStudent(int id);
        List<Student> GetAllStudentsBySkill(string skill);
        List<Student> GetAllStudents();
        List<Student> GetAllStudentsByQualification(string qualification);
    }
}
