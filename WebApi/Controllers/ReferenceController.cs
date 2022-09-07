using GriffonCMS.Infrastructure.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReferenceController : ControllerBase
{
    private IMediator _mediator;


    public ReferenceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateReferenceCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
