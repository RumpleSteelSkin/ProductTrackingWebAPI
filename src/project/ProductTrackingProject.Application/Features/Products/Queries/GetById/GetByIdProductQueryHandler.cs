using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetById;

public sealed class GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetByIdProductQuery, GetByIdProductResponseDto>
{
    public async Task<GetByIdProductResponseDto> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<GetByIdProductResponseDto>(await productRepository.GetAsync(x=>x.Id == request.Id,enableTracking:false,cancellationToken:cancellationToken));
    }
}