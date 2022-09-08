using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.Infrastructure.Command.Comments;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Comments;
public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, Response<Guid>>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public UpdateCommentCommandHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateCommentCommand command, CancellationToken cancellationToken)
    {
        var comment = await _commentRepository.GetByIdAsync(command.Id);

        if (comment == null)
        {
            throw new ApiException($"Comment Not Found.");
        }
        else
        {
            comment = _mapper.Map<CommentEntity>(command);
            _commentRepository.Update(comment);
            return new Response<Guid>(comment.Id);
        }
    }
}