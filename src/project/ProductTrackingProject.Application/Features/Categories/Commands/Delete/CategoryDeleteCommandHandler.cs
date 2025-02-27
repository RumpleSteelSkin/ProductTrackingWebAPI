using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Categories.Commands.Delete;

public class CategoryDeleteCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<CategoryDeleteCommand, string>
{
    public async Task<string> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.DeleteAsync(await categoryRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken) ?? throw new Exception($"{request.Id}'Id'li kategori bulunamadı."), cancellationToken: cancellationToken);
        return "Kategori Silindi.";
    }
}