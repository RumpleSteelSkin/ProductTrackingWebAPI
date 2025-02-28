using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;

public sealed class GetProductByPriceRangeQuery:IRequest<ICollection< GetProductByPriceRangeRequestDto>>
{
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
}