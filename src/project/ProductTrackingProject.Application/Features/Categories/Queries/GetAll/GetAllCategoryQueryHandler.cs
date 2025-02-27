using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetAll;
public class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<GetAllCategoryQuery, List<Category>>
{
    public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.GetAllAsync(enableTracking: false, include: false, cancellationToken: cancellationToken);
    }
}