using HandsOnAPIUsingModels.Model;
using HandsOnAPIUsingModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;
        public TeacherController() 
        { 
        teacherRepository = new TeacherRepository();
        }
        [HttpPost,Route("AddTeaacher")]
        public IActionResult Add(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpDelete,Route("DeleteTeacher/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                teacherRepository.Delete(id);
                return StatusCode(200, id);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll() 
        {
            try
            {
                List<Teacher> res = teacherRepository.GetAll();
                return StatusCode(200, res);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetTeacher/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
               Teacher teacher= teacherRepository.GetTeacher(id);
                return StatusCode(200,teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetTeachersBySubject/{subject}")]
        public IActionResult Get(string subject)
        {
            List<Teacher>teacher1 = teacherRepository.GetTeachersBySubject(subject);
            return StatusCode(200,teacher1);
        }

        [HttpPut,Route("UpdateTeacher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {

                teacherRepository.Update(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
             }
        }
       
    }
}
