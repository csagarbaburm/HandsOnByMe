using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet("Greet")]
        public string Greet()
        {
            return "Good morning Teachers";
        }
        [HttpGet("GetAll")]
        public string[] GetTeachers()
        {
            return new string[]
            {
                "amal","fredy","steve","karthik" };
        }
        [HttpGet]
        public string Hello()
            {
            return "hello World";
        }
        //[HttpGet("GetTeacherByStd/{std}")]
        //public string[] GetTeacherByClass(string std) 
        //    {
 

        //           }

    }
}
