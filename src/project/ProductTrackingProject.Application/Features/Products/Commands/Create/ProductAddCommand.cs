using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Commands.Create;

public sealed class ProductAddCommand:IRequest<string>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Guid CategoryId { get; set; }
}