using Core.Persistence.Repositories;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
using ProductTrackingProject.Persistence.Contexts;
namespace ProductTrackingProject.Persistence.Repositories;
public sealed class ProductRepository(ApplicationDbContext context) : EfRepositoryBase<Product, Guid, ApplicationDbContext>(context), IProductRepository;