using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;

public class GetProductsByCategoryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetProductsByCategoryQuery, List<GetProductsByCategoryResponseDto>>
{
    public async Task<List<GetProductsByCategoryResponseDto>> Handle(GetProductsByCategoryQuery request,
        CancellationToken cancellationToken)
    {
        Guid? guid = Guid.TryParse(request.IdOrName, out var tempId) ? tempId : null;
        List<Product> products;
        if (guid is not null)
            products = await productRepository.GetAllAsync(x => x.CategoryId == guid, enableTracking: false, cancellationToken: cancellationToken);
        else
            products = await productRepository.GetAllAsync(x => x.Category.Name.ToLower().Contains(request.IdOrName.ToLower()), enableTracking: false, cancellationToken: cancellationToken);
        return mapper.Map<List<GetProductsByCategoryResponseDto>>(products);
    }
}