using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Comments;
using GriffonCMS.Infrastructure.Queries.Comments;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Comments;
public class GetCommentHandler : IRequestHandler<GetCommentQuery, List<GetCommentDto>>
{

    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetCommentHandler> _logger;

    public GetCommentHandler(ICommentRepository commentRepository, IMapper mapper, ILogger<GetCommentHandler> logger)
    {
        _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetCommentDto>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
    {
        var response = await _commentRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetCommentDto>>(response);
        return mapped;
    }
}