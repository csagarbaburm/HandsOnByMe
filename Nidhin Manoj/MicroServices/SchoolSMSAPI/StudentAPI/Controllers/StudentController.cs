using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repositories;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpPost("Add Student")]

        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get All Students")]
        public IActionResult GetAllStudents() 
        {
            try
            {
                return Ok(studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get Students by ID/{id}")]
        public IActionResult GetStudentByID(int id)
        {
            try
            {
                return Ok(studentRepository.GetStudentByID(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get Students by STD/{std}")]
        public IActionResult GetStudentBySTD(string std)
        {
            try
            {
                return Ok(studentRepository.GetStudentsByStandard(std));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get Students by Standard and Section/{std}/{sec}")]
        public IActionResult GetStudentBySTD_SEC(string std, string sec)
        {
            try
            {
                return Ok(studentRepository.GetStudentByStandard_Section(std,sec));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("Update Student")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                return Ok(studentRepository.UpdateStudent(student));
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
