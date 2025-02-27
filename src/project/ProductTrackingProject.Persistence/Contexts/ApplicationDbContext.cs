using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Persistence.Contexts;
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}