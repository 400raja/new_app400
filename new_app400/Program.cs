var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! tamil made this change GIT CHG A");

app.Run();
