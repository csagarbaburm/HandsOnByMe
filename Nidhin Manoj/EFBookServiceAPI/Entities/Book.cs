using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFBookServiceAPI.Entities
{
    [Table("tbl_book")]
    public class Book
    {
        [Key]
        public string BookId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string BookName { get; set; }

        [Required]
        [Column(TypeName ="int")]
        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Author { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Lang { get; set; }
        [Required]
        [Column(TypeName="int")]
        public int ReleaseDate {  get; set; }


    }
}
