using System.Runtime.CompilerServices;
using TestShop.Interfaces;
using TestShop.Mocks;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IAllCars, MockCars>();   //  !!! You mush have link the correct interface and your model!!! instead you catch Error 
builder.Services.AddTransient<ICarCategory, MockCategory>();  //  !!! You mush have link the correct interface and your model!!! 

builder.Services.AddScoped<IAllCars, MockCars>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
