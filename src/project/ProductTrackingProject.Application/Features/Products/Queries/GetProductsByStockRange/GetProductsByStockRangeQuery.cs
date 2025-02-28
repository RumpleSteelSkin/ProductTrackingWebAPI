using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByStockRange;

public sealed class GetProductsByStockRangeQuery:IRequest<ICollection<GetProductsByStockRangeResponseDto>>
{
    public int MinStock { get; set; }
    public int MaxStock { get; set; }
}