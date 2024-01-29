using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Model
{
    public class Login
    {
        [Required(ErrorMessage ="pls enter Username")]
       public string Username { get; set; }
       
        [Required(ErrorMessage ="pls enter Password")]
        public string Password { get; set; }
    }
}
