using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetAll;
public sealed class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<GetAllCategoryQuery, ICollection<Category>>
{
    public async Task<ICollection<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.GetAllAsync(enableTracking: false, include: false, cancellationToken: cancellationToken);
    }
}