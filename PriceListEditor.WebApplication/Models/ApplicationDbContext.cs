using Microsoft.EntityFrameworkCore;
using PriceListEditor.WebApplication.Models;

namespace PriceListEditor.WebApplication.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<PriceList> PriceLists => Set<PriceList>();
    public DbSet<PriceListProduct> PriceListProducts => Set<PriceListProduct>();
    public DbSet<OptionalParameter> OptionalParameters => Set<OptionalParameter>();
    public DbSet<PriceListOptionalParameter> PriceListOptionalParameters => Set<PriceListOptionalParameter>();
}