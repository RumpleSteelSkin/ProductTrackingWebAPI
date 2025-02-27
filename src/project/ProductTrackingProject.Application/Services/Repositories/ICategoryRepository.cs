using Core.Persistence.Repositories;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Services.Repositories;
public interface ICategoryRepository: IAsyncRepository<Category,Guid>;