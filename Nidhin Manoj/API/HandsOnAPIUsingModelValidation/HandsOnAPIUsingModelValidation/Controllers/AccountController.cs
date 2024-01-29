using HandsOnAPIUsingModelValidation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace HandsOnAPIUsingModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        List<Login> logins = new List<Login>()
        {
            new Login(){Username= "Nidhin",Password="123"},
            new Login(){Username= "Nevin",Password="123"},
            new Login(){Username= "Febin",Password="123"},
            new Login(){Username= "Kevin",Password="123"},

        };
        List<User> users = new List<User>()
        { 
            new User(){Id=203,Name="Nidhin Manoj",Password="123",Email="nidhin@gmail.com",Mobile="8975634554",Username="Nidhin"}
        };
        [HttpPost,Route("Validate")]
        public IActionResult Validate(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    //var user = (from u in logins
                    //            where u.Username == login.Username && u.Password == login.Password
                    //            select u).SingleOrDefault();

                    var user = (from l in logins
                                join u in users
                                on l.Username equals u.Username
                                where u.Username == login.Username && u.Password == login.Password
                                select u).SingleOrDefault();
                    if (user != null)
                    {
                        return StatusCode(200, user);
                    }
                    else
                    {
                        return StatusCode(200, new JsonResult("Invalid user Credentials"));
                    }
                }
                else
                {
                    return BadRequest();
                }
            }

            catch (Exception ex)
            {

                return StatusCode(502, ex);
            }
        }
        [HttpPost,Route("Register")]
        public IActionResult Register([FromBody]User user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    user.Id = new Random().Next(1000, 9999);
                    users.Add(user);
                    return Ok(user);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
