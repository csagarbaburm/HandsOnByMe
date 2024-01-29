using HandsOnAPIWithEFCodeFisrtDemo1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HandsOnAPIWithEFCodeFisrtDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyContext _context;
        public StudentController()
        {
            _context = new MyContext();
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add([FromBody]Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Student>students= _context.Students.ToList();  
                return StatusCode(200, students);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet,Route("Get/{id}")]
        public IActionResult Get(int id) 
        {
            try
            {
                Student student = _context.Students.SingleOrDefault(s => s.Id == id);
                return StatusCode(200, student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("UpdateStudent")]
        public IActionResult Update([FromBody] Student student)
        {
            try
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete (int id)
        {
            try
            {
                Student student=_context.Students.Find(id);
                _context.Students.Remove(student);
                _context.SaveChanges();
                return Ok(new JsonResult ("student is deleted",student));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
