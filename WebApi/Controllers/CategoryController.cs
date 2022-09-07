using GriffonCMS.Infrastructure.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private IMediator _mediator;


    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateCategoryCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
