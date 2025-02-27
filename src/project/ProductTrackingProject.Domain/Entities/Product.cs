using Core.Persistence.Entities;
namespace ProductTrackingProject.Domain.Entities;
public sealed class Product:Entity<Guid>
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Guid? CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}