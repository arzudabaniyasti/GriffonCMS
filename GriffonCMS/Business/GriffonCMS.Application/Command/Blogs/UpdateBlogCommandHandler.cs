using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Blogs;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Blogs;
public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, Response<Guid>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public UpdateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateBlogCommand command, CancellationToken cancellationToken)
    {
        var blog = await _blogRepository.GetByIdAsync(command.Id);

        if (blog == null)
        {
            throw new ApiException($"Blog Not Found.");
        }
        else
        {

            blog = _mapper.Map<BlogEntity>(command);
            _blogRepository.Update(blog);
            return new Response<Guid>(blog.Id);
        }
    }
}