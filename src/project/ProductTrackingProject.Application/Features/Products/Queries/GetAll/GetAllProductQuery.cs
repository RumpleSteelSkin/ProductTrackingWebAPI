using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Queries.GetAll;
public sealed class GetAllProductQuery:IRequest<ICollection<GetAllProductResponseDto>>;