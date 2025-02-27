using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Create;
public class CategoryAddCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<CategoryAddCommand, Category>
{
    public async Task<Category> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
    {
        return await categoryRepository.AddAsync(new Category() { Name = request.Name }, cancellationToken: cancellationToken); 
    }
}