using MediatR;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetAll;
public sealed class GetAllCategoryQuery : IRequest<ICollection<Category>>;