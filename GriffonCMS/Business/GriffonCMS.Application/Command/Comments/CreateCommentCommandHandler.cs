using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Comments;
using MediatR;

namespace GriffonCMS.Application.Command.Comments;
public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Guid>
{
    ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public CreateCommentCommandHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = _mapper.Map<CommentEntity>(request);
        await _commentRepository.AddAsync(comment);
        return comment.Id;
    }
}