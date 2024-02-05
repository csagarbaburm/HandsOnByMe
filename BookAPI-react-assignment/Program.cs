
using BookAPI_react_assignment.Entities;
using BookAPI_react_assignment.Repositories;

namespace BookAPI_react_assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<MyContext>();
            builder.Services.AddTransient<BookRepository>();
            builder.Services.AddControllers();
            builder.Services.AddCors(c=>
            c.AddPolicy("AllowCors", options=>
            options.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
            ));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseCors("AllowCors");


            app.MapControllers();

            app.Run();
        }
    }
}
