using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Blogs;
using MediatR;

namespace GriffonCMS.Application.Command.Blogs;
public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Guid>
{
    IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        var blog = _mapper.Map<BlogEntity>(request);
        await _blogRepository.AddAsync(blog);
        return blog.Id;
    }
}