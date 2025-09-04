var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession(); //  enable the session this is important for use save and retrieve the temporal data from Session.
                               //  For HttpContext.Session.SetString("ID", id_from_DB) and ttpContext.Session.GetString("ID", id_from_DB);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseSession();   // enable the session this is important for use save and retrieve the temporal data from Session.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
