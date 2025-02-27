using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;

public class GetProductsByCategoryQuery : IRequest<List<GetProductsByCategoryResponseDto>>
{
    public string IdOrName { get; set; }
}