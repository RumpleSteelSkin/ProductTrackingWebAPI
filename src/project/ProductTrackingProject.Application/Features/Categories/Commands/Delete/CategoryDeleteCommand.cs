using MediatR;

namespace ProductTrackingProject.Application.Features.Categories.Commands.Delete;
public sealed class CategoryDeleteCommand:IRequest<string>
{
    public Guid Id { get; set; }
}