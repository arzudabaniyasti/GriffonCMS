using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Queries.Abouts;
using GriffonCMS.Infrastructure.Queries.Categories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]

public class AboutController : ControllerBase
{
    private IMediator _mediator;


    public AboutController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAboutQuery();
        return Ok(await Mediator.Send(query));
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateAboutCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteAboutByIdCommand { Id = id }));
    }
    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> Put(Guid id, UpdateAboutCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        return Ok(await Mediator.Send(command));
    }
}
