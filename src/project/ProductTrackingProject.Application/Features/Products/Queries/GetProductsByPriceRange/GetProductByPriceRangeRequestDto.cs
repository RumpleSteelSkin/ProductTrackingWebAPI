namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;

public sealed class GetProductByPriceRangeRequestDto()
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string CategoryName { get; set; }
}