var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/home", () => "Hello World!");
//app.MapGet("/home", () => "Hello World!");
//app.MapPost("/home", () => "Hello World!");
//app.MapPut("/home", () => "Hello World!");
//app.MapDelete("/home", () => "Hello World!");
app.UseRouting(); 

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/home",async (context) =>
    {
        await context.Response.WriteAsync("This is home Page GET");
    });
    endpoints.MapPost("/home",async (context) =>
    {
        await context.Response.WriteAsync("This is home Page Map Post");
    });
    endpoints.MapPut("/home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page PUT Post");
    });

    endpoints.MapDelete("/home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page DEL Post");
    });


});
app.Run(async(HttpContext context) =>
{
        await context.Response.WriteAsync($"Page Not Found ");

});

app.Run();
