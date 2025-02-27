using MediatR;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Application.Features.Categories.Queries.GetAll;
public class GetAllCategoryQuery : IRequest<List<Category>>;