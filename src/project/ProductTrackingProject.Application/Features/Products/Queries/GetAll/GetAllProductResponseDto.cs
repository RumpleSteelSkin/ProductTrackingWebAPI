namespace ProductTrackingProject.Application.Features.Products.Queries.GetAll;

public sealed class GetAllProductResponseDto()
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string CategoryName { get; set; }
}