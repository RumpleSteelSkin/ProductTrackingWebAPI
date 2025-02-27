using MediatR;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetById;

public sealed class GetByIdProductQuery:IRequest<GetByIdProductResponseDto>
{
    public Guid Id { get; set; }
}