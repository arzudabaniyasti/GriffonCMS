using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Comments;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Comments;
public class DeleteCommentByIdCommandHandler : IRequestHandler<DeleteCommentByIdCommand, Guid>
{

    private readonly ICommentRepository _commentRepository;
    public DeleteCommentByIdCommandHandler(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }
    public async Task<Guid> Handle(DeleteCommentByIdCommand command, CancellationToken cancellationToken)
    {
        var comment = await _commentRepository.GetByIdAsync(command.Id);
        if (comment == null) throw new ApiException($"Comment Not Found.");
        await _commentRepository.DeleteByIdAsync(comment.Id);
        return comment.Id;
    }
}