using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Commands.Delete;

public sealed class ProductDeleteCommandHandler(IProductRepository productRepository) : IRequestHandler<ProductDeleteCommand, string>
{
    public async Task<string> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
    {
        await productRepository.DeleteAsync(await productRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken, include: false, enableTracking: false) ?? throw new Exception($"{request.Id} id'li ürün bulunamadı!"), cancellationToken: cancellationToken);
        return "Ürün Silindi.";
    }
}