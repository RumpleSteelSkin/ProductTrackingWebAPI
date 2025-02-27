namespace ProductTrackingProject.Application.Features.Products.Queries.GetById;

public sealed class GetByIdProductResponseDto()
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string CategoryName { get; set; }
}