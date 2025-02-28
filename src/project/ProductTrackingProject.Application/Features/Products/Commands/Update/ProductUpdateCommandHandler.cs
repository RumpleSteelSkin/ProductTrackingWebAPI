using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Commands.Update;

public sealed class ProductUpdateCommandHandler(IProductRepository productRepository,IMapper mapper) : IRequestHandler<ProductUpdateCommand, string>
{
    public async Task<string> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
    {
        await productRepository.UpdateAsync(mapper.Map<Product>(request), cancellationToken: cancellationToken);
        return "Kategori Güncellendi.";
    }
}