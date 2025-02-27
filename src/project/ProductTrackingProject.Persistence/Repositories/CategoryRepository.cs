using Core.Persistence.Repositories;
using ProductTrackingProject.Application.Services.Repositories;
using ProductTrackingProject.Domain.Entities;
using ProductTrackingProject.Persistence.Contexts;
namespace ProductTrackingProject.Persistence.Repositories;
public sealed class CategoryRepository(ApplicationDbContext context) :EfRepositoryBase<Category,Guid,ApplicationDbContext>(context),ICategoryRepository;