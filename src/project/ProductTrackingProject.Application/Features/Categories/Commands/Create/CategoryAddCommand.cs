using MediatR;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Create;
public class CategoryAddCommand:IRequest<string>
{
    public string Name { get; set; }
}