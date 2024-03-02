var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseRouting();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(

    name:"default",
    pattern:"{controller=home}/{action=index}"
);
app.Run();
