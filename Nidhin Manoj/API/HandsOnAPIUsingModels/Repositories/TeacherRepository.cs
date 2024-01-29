using HandsOnAPIUsingModels.Model;

namespace HandsOnAPIUsingModels.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){Id=12121,Name="nidhin",Subject="english",Stds= new string[]{"3"} }    
        };

        public void Add(Teacher teacher)
        {
            teachers.Add(teacher); 
        }
       
        public void Delete(int id)
        {
           foreach (var item in teachers) 
            {
                if (item.Id == id)
                {
                    teachers.Remove(item);
                }
            }
        }

        public List<Teacher> GetAll()
        {
           return teachers;
        }

        public Teacher GetTeacher(int id)
        {
            try
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Id == id)
                        return teacher;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Teacher> GetTeachersBySubject(string subject)
        {
            try
            {
                List<Teacher> teacherswithsubject = new List<Teacher>();
                foreach (var teacher in teachers)
                {
                    if (teacher.Subject == subject)
                        teacherswithsubject.Add(teacher);

                }
                return teacherswithsubject;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Teacher teacher)
        {
            try
            {
                foreach (var item in teachers)
                {
                    if (item.Id == teacher.Id)
                    {
                        item.Subject = teacher.Subject;
                        item.Name = teacher.Name;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
