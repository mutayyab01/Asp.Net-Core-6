var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (content, next) =>
{
    await content.Response.WriteAsync("Programentor \n");
    await  next(content);
    await content.Response.WriteAsync("The ENd");
});

app.Use(async (content, next) =>
{
    await content.Response.WriteAsync("Welcome to asp.net core web application \n");
    await next(content);
    await content.Response.WriteAsync("The ENd123");
});

app.Run(async (content) =>
{
    await content.Response.WriteAsync("\n-----------------------");
});


app.Run();
