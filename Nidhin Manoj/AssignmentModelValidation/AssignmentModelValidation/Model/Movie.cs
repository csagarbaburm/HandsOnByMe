using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace AssignmentModelValidation.Model
{
    public class Movie
    {
        public int MovieId {  get; set; }
        [Required(ErrorMessage ="enter the movie name")] 
        public string MovieName { get; set;}
        [Required(ErrorMessage ="enter the language")]
        public string Lang{ get; set;}
        [Required(ErrorMessage = "enter the year of release")]
        //[RegularExpression("\\d",ErrorMessage ="invalid format")]
        public int ReleaseYear { get; set;}
        [Required(ErrorMessage = "enter the actor name")]
        //[RegularExpression("\\D", ErrorMessage = "invalid format")]
        public string Actor { get; set;}
        [Required(ErrorMessage = "enter the director name")]
        //[RegularExpression("\\D", ErrorMessage = "invalid format")]
        public string Director { get; set;}


    }
}
