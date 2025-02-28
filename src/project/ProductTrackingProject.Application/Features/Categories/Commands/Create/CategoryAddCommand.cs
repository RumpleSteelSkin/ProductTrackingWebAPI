using MediatR;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Create;
public sealed class CategoryAddCommand:IRequest<string>
{
    public string Name { get; set; }
}