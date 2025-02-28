using AutoMapper;
using ProductTrackingProject.Application.Features.Categories.Queries.GetById;
using ProductTrackingProject.Domain.Entities;

namespace ProductTrackingProject.Application.Features.Categories.Profiles;
public sealed class CategoriesMapper : Profile
{
    public CategoriesMapper()
    {
        CreateMap<Category, GetByIdCategoryResponseDto>();
    }
}