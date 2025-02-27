using MediatR;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Create;
public class CategoryAddCommand:IRequest<Category>
{
    public string Name { get; set; }
}