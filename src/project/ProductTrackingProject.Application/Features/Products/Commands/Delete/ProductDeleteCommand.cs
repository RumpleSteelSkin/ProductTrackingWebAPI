using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Commands.Delete;

public sealed class ProductDeleteCommand:IRequest<string>
{
    public Guid Id { get; set; }
}