using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;

public sealed class
    GetProductByPriceRangeQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetProductByPriceRangeQuery,
    List<GetProductByPriceRangeRequestDto>>
{
    public async Task<List<GetProductByPriceRangeRequestDto>> Handle(GetProductByPriceRangeQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<List<GetProductByPriceRangeRequestDto>>(await productRepository.GetAllAsync(
            x => x.Price >= request.MinPrice && x.Price <= request.MaxPrice, enableTracking: false,
            cancellationToken: cancellationToken));
    }
}