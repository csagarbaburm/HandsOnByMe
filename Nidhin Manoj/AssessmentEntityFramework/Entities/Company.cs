using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentEntityFramework.Entities
{
    [Table("tbl_company")]
    public class Company
    {
        [Key]
        public int companyId { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Address { get; set; }

    }
}

  