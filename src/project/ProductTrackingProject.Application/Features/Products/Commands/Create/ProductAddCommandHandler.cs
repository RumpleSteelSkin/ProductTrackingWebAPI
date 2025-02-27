using AutoMapper;
using MediatR;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Commands.Create;

public sealed class ProductAddCommandHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<ProductAddCommand, string>
{
    public async Task<string> Handle(ProductAddCommand request, CancellationToken cancellationToken)
    {
        await productRepository.AddAsync(mapper.Map<Product>(request),cancellationToken:cancellationToken);
        return "Ürün Eklendi.";
    }
}