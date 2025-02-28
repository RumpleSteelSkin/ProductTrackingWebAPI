using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Commands.Update;
public sealed class CategoryUpdateCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<CategoryUpdateCommand, string>
{
    public async Task<string> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.UpdateAsync(new Category() { Id = request.Id, Name = request.Name}, cancellationToken: cancellationToken);
        return "Kategori Güncellendi.";
    }
}