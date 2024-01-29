using System.ComponentModel.DataAnnotations;

namespace HandsOnAPIUsingModelValidation.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="enter name")]
        public string Name { get; set; }
        [Range(18,90,ErrorMessage ="enter the age between 18 to 90")]
        public string Age {  get; set; }
        [Required(ErrorMessage ="enter mail")]
        [EmailAddress(ErrorMessage = "invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "enter password")]
        [RegularExpression("[a-zA-z0-9]{6,8}",ErrorMessage ="password should be 6 to 8 characters long")]
        public string Password { get; set; }
        [Required(ErrorMessage = "enter mobile")]
        [RegularExpression("[6-9]\\d{9}",ErrorMessage ="invalid mobile number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "enter username")]
        public string Username { get; set; }
    }
}
