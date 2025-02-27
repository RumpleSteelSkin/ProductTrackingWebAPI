using AutoMapper;
using ProductTrackingProject.Application.Features.Products.Commands.Create;
using ProductTrackingProject.Application.Features.Products.Commands.Update;
using ProductTrackingProject.Application.Features.Products.Queries.GetAll;
using ProductTrackingProject.Application.Features.Products.Queries.GetById;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByStockRange;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Products.Profiles;

public class ProductsMapper : Profile
{
    public ProductsMapper()
    {
        CreateMap<ProductAddCommand, Product>();
        CreateMap<ProductUpdateCommand, Product>();
        CreateMap<Product, GetAllProductResponseDto>();
        CreateMap<Product, GetByIdProductResponseDto>();
        CreateMap<Product, GetProductsByCategoryResponseDto>();
        CreateMap<Product, GetProductByPriceRangeRequestDto>();
        CreateMap<Product, GetProductsByStockRangeResponseDto>();
    }
}