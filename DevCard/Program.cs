var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllersWithViews();

//Build app
var app = builder.Build();

//Middelware
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
