var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(options => {});

var app = builder.Build();

app.MapGet("/", () => "{ 'status': 'operative' }");

app.MapControllers();

app.Run();
