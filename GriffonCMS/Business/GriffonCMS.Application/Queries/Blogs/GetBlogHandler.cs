using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Blogs;
using GriffonCMS.Infrastructure.Queries.Blogs;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Blogs;
public class GetBlogHandler : IRequestHandler<GetBlogQuery, List<GetBlogDto>>
{

    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetBlogHandler> _logger;

    public GetBlogHandler(IBlogRepository blogRepository, IMapper mapper, ILogger<GetBlogHandler> logger)
    {
        _blogRepository = blogRepository ?? throw new ArgumentNullException(nameof(blogRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetBlogDto>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
    {
        var response = await _blogRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetBlogDto>>(response);
        return mapped;
    }
}