using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;

public sealed class GetProductsByCategoryQuery : IRequest<ICollection<GetProductsByCategoryResponseDto>>
{
    public string IdOrName { get; set; }
}