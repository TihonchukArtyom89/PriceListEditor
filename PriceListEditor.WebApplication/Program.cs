using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PriceListEditor.WebApplication.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => { options.UseSqlServer(builder.Configuration["ConnectionStrings:PriceListEditor.WebApplicationConnection"]); });
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
SeedData.EnsurePopulated(app);//fill db with sample data
app.Run();
