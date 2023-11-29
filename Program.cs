using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApi.Models;
using WebApi.Models.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ApplicationDbContext>(options => {
            var connectionString = builder.Configuration.GetConnectionString("MariaDbConnectionString");
            Console.WriteLine("this is a connection string: " + connectionString);

            options.UseSqlServer(connectionString);
        });

        builder.Services.AddTransient<IUserRepository, UserRepository>();

        builder.Services.AddControllers();
        builder.Services.AddCors(options => { });
        builder.Services.AddSwaggerGen(c => {
            c.SwaggerDoc(
                "v1",
                new OpenApiInfo
                {
                    Title = "Web Api Sample",
                    Description = "Web API made with .NET framework for education",
                    Version = "v1"
                }
            );
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment()) {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
            });
        }

        app.MapControllers();
        app.Run();
    }
}