
using GriffonCMS.Infrastructure.Command.References;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Queries.Categories;
using GriffonCMS.Infrastructure.Queries.References;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]

public class ReferenceController : ControllerBase
{
    private IMediator _mediator;


    public ReferenceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetReferenceQuery();
        return Ok(await Mediator.Send(query));
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateReferenceCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteReferenceByIdCommand { Id = id }));
    }
    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> Put(Guid id, UpdateReferenceCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        return Ok(await Mediator.Send(command));
    }
}
