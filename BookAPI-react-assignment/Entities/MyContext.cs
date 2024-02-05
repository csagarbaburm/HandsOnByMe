using Microsoft.EntityFrameworkCore;

namespace BookAPI_react_assignment.Entities
{
    public class MyContext:DbContext
    {

        private readonly IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Myconnection"));
        }





    }
}
