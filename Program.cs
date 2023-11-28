using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(options => {});
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc(
        "v1",
        new OpenApiInfo {
            Title = "Web Api Sample",
            Description = "Web API made with .NET framework for education",
            Version = "v1"
        }
    );
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => {
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
});
app.MapControllers();

app.Run();
