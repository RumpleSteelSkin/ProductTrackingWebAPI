using MediatR;

namespace ProductTrackingProject.Application.Features.Categories.Commands.Update;
public class CategoryUpdateCommand:IRequest<string>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}