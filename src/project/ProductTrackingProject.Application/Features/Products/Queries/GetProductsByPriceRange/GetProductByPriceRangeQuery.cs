using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;

public sealed class GetProductByPriceRangeQuery:IRequest<List< GetProductByPriceRangeRequestDto>>
{
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
}