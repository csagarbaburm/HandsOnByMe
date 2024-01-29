using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Model;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> Students = new List<Student>()
        {
            new Student{Id=87367,Name="nidhin",Age=19,Std="5"},
            new Student{Id=8545,Name="nevin",Age=22,Std="10"}
        };

        [HttpPost, Route("AddStudent")]
        public Student AddStudent (Student student)
            {
            Students.Add(student);
            return student;
            }
        [HttpGet("GetStudents")]
        public List<Student>GetStudents ()
        {
            return Students;
        }
        [HttpGet,Route("GetStudentById/{id}")]
        public Student GetStudent(int id)
        {
            foreach (var item in Students)
            {
                if (item.Id == id)
                {

                    return item;
                }

            }
            return null;

            
        }
        [HttpGet, Route("GetStudentByName/{name}")]
        public Student GetStudent(string name)
        {
            foreach (var item in Students)
            {
                if (item.Name == name)
                {

                    return item;
                }

            }
            return null;


        }
        [HttpDelete,Route("Deletestudent/{id}")]
        public string DeleteStudent (int id)
        {
            foreach(var item in Students)
            {
              if(item.Id == id)
                {
                    Students.Remove(item);
                    return "student deleted";
                }
            }
            return "invalid id";
        }
    }
}
