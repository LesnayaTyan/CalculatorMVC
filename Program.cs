using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebCalculator.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebCalculatorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebCalculatorContext") ?? throw new InvalidOperationException("Connection string 'WebCalculatorContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Calculators}/{action=Create}/{id?}");

app.Run();
