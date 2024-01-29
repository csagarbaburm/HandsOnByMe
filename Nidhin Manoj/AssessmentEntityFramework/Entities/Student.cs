
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AssessmentEntityFramework.Entities
{
    [Table("tbl_stud")]
    public class Student
    {
        [Key]
        public string StudentId {  get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Qualification { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Skill { get; set; }

    }
} 