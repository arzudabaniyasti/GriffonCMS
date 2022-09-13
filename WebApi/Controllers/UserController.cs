using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Queries.Users;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]

public class UserController : ControllerBase
{
    private IMediator _mediator;


    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteUserByIdCommand { Id = id }));
    }
    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> Put(Guid id, UpdateUserCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        return Ok(await Mediator.Send(command));
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetUserQuery();
        return Ok(await Mediator.Send(query));
    }
}
