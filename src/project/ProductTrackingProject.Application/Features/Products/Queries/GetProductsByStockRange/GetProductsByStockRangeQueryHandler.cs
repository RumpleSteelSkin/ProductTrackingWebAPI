using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByStockRange;

public sealed class
    GetProductsByStockRangeQueryHandler(IProductRepository productRepository,IMapper mapper) : IRequestHandler<GetProductsByStockRangeQuery,
    List<GetProductsByStockRangeResponseDto>>
{
    public async Task<List<GetProductsByStockRangeResponseDto>> Handle(GetProductsByStockRangeQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<List<GetProductsByStockRangeResponseDto>>(await productRepository.GetAllAsync(
            x => x.Stock >= request.MinStock && x.Stock <= request.MaxStock, enableTracking: false,
            cancellationToken: cancellationToken));
    }
}