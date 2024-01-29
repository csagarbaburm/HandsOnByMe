using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Repository;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        //Endpoints...

        [HttpPost("Register")]
        public IActionResult Create(User user)
        {
            userRepository.Register(user);
            return StatusCode(200, "Registered");
        }
        [HttpPut("Edit user")]
        public IActionResult Update(User user)
        {
            userRepository.EditUser(user);
            return StatusCode(200, "Edited");
        }

        [HttpPost("Login")]
        public IActionResult Login(Login login) 
        { 
            User usr=userRepository.Validate(login.UserName, login.Password);

            if(usr != null)
            {
                return Ok(usr);
            }
            return BadRequest();
        }
    }
}
