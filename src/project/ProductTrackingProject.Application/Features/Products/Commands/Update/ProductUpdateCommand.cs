using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Commands.Update;

public sealed class ProductUpdateCommand:IRequest<string>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Guid? CategoryId { get; set; }
}