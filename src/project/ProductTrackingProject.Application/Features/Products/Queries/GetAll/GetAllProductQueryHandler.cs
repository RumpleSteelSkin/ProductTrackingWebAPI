using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetAll;

public sealed class GetAllProductQueryHandler(IProductRepository productRepository,IMapper mapper) : IRequestHandler<GetAllProductQuery, ICollection<GetAllProductResponseDto>>
{
    public async Task<ICollection<GetAllProductResponseDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<GetAllProductResponseDto>>(await productRepository.GetAllAsync(cancellationToken:cancellationToken));
    }
}