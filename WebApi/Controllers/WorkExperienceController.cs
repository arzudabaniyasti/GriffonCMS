using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Blogs;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Command.WorkExperiences;
using GriffonCMS.Infrastructure.Queries.Categories;
using GriffonCMS.Infrastructure.Queries.WorkExperiences;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]

public class WorkExperienceController : ControllerBase
{
    private IMediator _mediator;


    public WorkExperienceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetWorkExperienceQuery();
        return Ok(await Mediator.Send(query));
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateWorkExperienceCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteWorkExperienceByIdCommand { Id = id }));
    }
    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> Put(Guid id, UpdateWorkExperienceCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        return Ok(await Mediator.Send(command));
    }
}
