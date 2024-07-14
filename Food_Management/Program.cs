var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Add MVC services

var app = builder.Build();




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Map default controller route to CategoryController's Index action
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();
