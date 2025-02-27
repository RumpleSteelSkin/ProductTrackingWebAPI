using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductTrackingProject.Application.Features.Products.Commands.Create;
using ProductTrackingProject.Application.Features.Products.Commands.Delete;
using ProductTrackingProject.Application.Features.Products.Commands.DeleteAll;
using ProductTrackingProject.Application.Features.Products.Commands.Update;
using ProductTrackingProject.Application.Features.Products.Queries.GetAll;
using ProductTrackingProject.Application.Features.Products.Queries.GetById;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByCategory;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByPriceRange;
using ProductTrackingProject.Application.Features.Products.Queries.GetProductsByStockRange;

namespace ProductTrackingProject.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(ProductUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await mediator.Send(new ProductDeleteCommand() { Id = id }));
        }

        [HttpDelete("DeleteAll")]
        public async Task<IActionResult> DeleteAll()
        {
            return Ok(await mediator.Send(new ProductDeleteAllCommand()));
        }
        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new GetAllProductQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await mediator.Send(new GetByIdProductQuery() { Id = id }));
        }

        [HttpGet("GetProductByCategory")]
        public async Task<IActionResult> GetProductByCategory(string idOrName)
        {
            return Ok(await mediator.Send(new GetProductsByCategoryQuery() { IdOrName = idOrName }));
        }

        [HttpGet("GetProductByPriceRange")]
        public async Task<IActionResult> GetProductByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return Ok(await mediator.Send(new GetProductByPriceRangeQuery() { MinPrice = minPrice, MaxPrice = maxPrice }));
        }

        [HttpGet("GetProductByStockRange")]
        public async Task<IActionResult> GetProductByPriceRange(int minStock, int maxStock)
        {
            return Ok(await mediator.Send(new GetProductsByStockRangeQuery() { MaxStock = maxStock, MinStock = minStock }));
        }
    }
}
