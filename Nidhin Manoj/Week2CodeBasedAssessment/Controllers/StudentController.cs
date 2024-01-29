using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2CodeBasedAssessment.Model;
using Week2CodeBasedAssessment.Repositories;

namespace Week2CodeBasedAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        [HttpPost,Route("Add Student")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return StatusCode(200, "Student Added");
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet,Route("Get All Students")]

        public IActionResult GetAllStudent()
        {
            try
            {
                return StatusCode(200, studentRepository.GetAllStudents());
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet, Route("Get Student by ID/{id}")]
        public IActionResult GetStudent(int id)
        {
            try
            {
                return StatusCode(200, studentRepository.FindStudentByID(id));
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet, Route("Get Student by Qualification/{quali}")]
        public IActionResult GetStudentbyQualification(string quali)
        {
            try
            {
                return StatusCode(200, studentRepository.GetAllStudentsByQualification(quali));
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet, Route("Get Student by skill/{skill}")]
        public IActionResult GetStudentBySkill(string skill)
        {
            try
            {
                return StatusCode(200, studentRepository.GetAllStudentsBySkill(skill));
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }


        [HttpPut, Route("Update student qualification/{id}/{quali}")]
        public IActionResult UpdateStudentQuali(int id, string quali)
        {
            try
            {
                studentRepository.UpdateStudentQualification(id, quali);
                return StatusCode(200, "Student updated");
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpPut, Route("Update student skill/{id}/{skill}")]
        public IActionResult UpdateStudentskill(int id, string skill)
        {
            try
            {
                studentRepository.UpdateStudentSkill(id, skill);
                return StatusCode(200, "Student updated");
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }

        [HttpDelete, Route("Delete student/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
                return StatusCode(200, "Student Deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(400, ex.Message);
            }
        }




    }
}

