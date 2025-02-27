using MediatR;

namespace ProductTrackingProject.Application.Features.Products.Commands.DeleteAll;

public sealed class ProductDeleteAllCommand : IRequest<string>;