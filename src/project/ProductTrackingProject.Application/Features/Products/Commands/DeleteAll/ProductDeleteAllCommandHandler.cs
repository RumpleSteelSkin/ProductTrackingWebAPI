using MediatR;
using ProductTrackingProject.Application.Services.Repositories;

namespace ProductTrackingProject.Application.Features.Products.Commands.DeleteAll;

public sealed class ProductDeleteAllCommandHandler(IProductRepository productRepository)
    : IRequestHandler<ProductDeleteAllCommand, string>
{
    public async Task<string> Handle(ProductDeleteAllCommand request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken);
        foreach (var product in products)
            await productRepository.DeleteAsync(product, cancellationToken: cancellationToken);
        return "Tüm Ürünler Silindi!";
    }
}