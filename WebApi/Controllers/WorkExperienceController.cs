using GriffonCMS.Infrastructure.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkExperienceController : ControllerBase
{
    private IMediator _mediator;


    public WorkExperienceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateWorkExperienceCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
