using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductTrackingProject.Application.Features.Categories.Commands.Create;
using ProductTrackingProject.Application.Features.Categories.Commands.Delete;
using ProductTrackingProject.Application.Features.Categories.Commands.Update;
using ProductTrackingProject.Application.Features.Categories.Queries.GetAll;
using ProductTrackingProject.Application.Features.Categories.Queries.GetById;

namespace ProductTrackingProject.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(CategoryAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(CategoryUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await mediator.Send(new CategoryDeleteCommand(){Id = id}));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new GetAllCategoryQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await mediator.Send(new GetByIdCategoryQuery() { Id = id }));
        }
    }
}
