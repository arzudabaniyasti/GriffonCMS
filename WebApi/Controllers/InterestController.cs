
using GriffonCMS.Infrastructure.Command.Contacts;
using GriffonCMS.Infrastructure.Command.Interests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class InterestController : ControllerBase
{
    private IMediator _mediator;


    public InterestController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateInterestCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteContactByIdCommand { Id = id }));
    }
}
