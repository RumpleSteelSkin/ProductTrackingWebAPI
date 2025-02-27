using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetById;
public sealed class GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository,IMapper mapper) : IRequestHandler<GetByIdCategoryQuery, GetByIdCategoryResponseDto>
{
    public async Task<GetByIdCategoryResponseDto> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<GetByIdCategoryResponseDto>(await categoryRepository.GetAsync(x => x.Id == request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}