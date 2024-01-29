using Microsoft.EntityFrameworkCore;

namespace EFBookServiceAPI.Entities
{
    public class Mycontext : DbContext
    {
        private readonly IConfiguration configuration;

        public Mycontext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //define entity
        public DbSet<Book> Books { get; set; }
        
        //confine connect

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=INTERNS112\SQL2022;Initial Catalog=TrainingDB;User ID=sa;Password=Password123.;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
