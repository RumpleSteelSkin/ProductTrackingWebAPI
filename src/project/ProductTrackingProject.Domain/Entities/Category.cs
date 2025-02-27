using Core.Persistence.Entities;
namespace ProductTrackingProject.Domain.Entities;
public sealed class Category:Entity<Guid>
{
    public required string Name { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}