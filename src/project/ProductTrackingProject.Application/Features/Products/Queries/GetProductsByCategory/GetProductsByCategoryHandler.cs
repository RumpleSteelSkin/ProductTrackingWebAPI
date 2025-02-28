using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;

public sealed class GetProductsByCategoryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetProductsByCategoryQuery, ICollection<GetProductsByCategoryResponseDto>>
{
    public async Task<ICollection<GetProductsByCategoryResponseDto>> Handle(GetProductsByCategoryQuery request,
        CancellationToken cancellationToken)
    {
        Guid? guid = Guid.TryParse(request.IdOrName, out var tempId) ? tempId : null;
        ICollection<Product> products;
        if (guid is not null)
            products = await productRepository.GetAllAsync(x => x.CategoryId == guid, enableTracking: false, cancellationToken: cancellationToken);
        else
            products = await productRepository.GetAllAsync(x => x.Category.Name.ToLower().Contains(request.IdOrName.ToLower()), enableTracking: false, cancellationToken: cancellationToken);
        return mapper.Map<ICollection<GetProductsByCategoryResponseDto>>(products);
    }
}