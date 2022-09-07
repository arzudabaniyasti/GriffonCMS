﻿
using GriffonCMS.Infrastructure.Command.Comments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentController : ControllerBase
{
    private IMediator _mediator;


    public CommentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateCommentCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteCommentByIdCommand { Id = id }));
    }
}
