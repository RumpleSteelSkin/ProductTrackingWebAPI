using MediatR;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetById;
public sealed class GetByIdCategoryQuery:IRequest<GetByIdCategoryResponseDto>
{
    public Guid Id { get; set; }
}