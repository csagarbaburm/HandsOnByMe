using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HandsOnAPIWithEFCodeFisrtDemo1.Entities
{
    public class MyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }            
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = RMPLC4CE8361801\SQL2022; Initial Catalog = TrainingDB1; User ID = sa; Password =Password123.; Trust Server Certificate = True");
        }
    }
}
