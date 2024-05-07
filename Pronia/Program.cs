using Pronia.DataAccesLayer;

var builder = WebApplication.CreateBuilder(args);
 builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProniaContext>();
 var app = builder.Build();
 app.UseStaticFiles();
// app.MapControllerRoute("default", "{controller =home}/{action=index}");
app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
app.Run();
