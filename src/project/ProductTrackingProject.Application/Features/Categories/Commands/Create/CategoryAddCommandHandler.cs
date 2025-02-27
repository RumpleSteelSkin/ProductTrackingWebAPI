using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Create;
public class CategoryAddCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<CategoryAddCommand, string>
{
    public async Task<string> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.AddAsync(new Category() { Name = request.Name }, cancellationToken: cancellationToken);
        return "Kategori Eklendi.";
    }
}