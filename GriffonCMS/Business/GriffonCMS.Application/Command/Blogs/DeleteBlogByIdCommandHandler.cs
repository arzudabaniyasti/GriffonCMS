using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Blogs;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Blogs;
public class DeleteBlogByIdCommandHandler : IRequestHandler<DeleteBlogByIdCommand, Guid>
{

    private readonly IBlogRepository _blogRepository;
    public DeleteBlogByIdCommandHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    public async Task<Guid> Handle(DeleteBlogByIdCommand command, CancellationToken cancellationToken)
    {
        var blog = await _blogRepository.GetByIdAsync(command.Id);
        if (blog == null) throw new ApiException($":Blog Not Found.");
        await _blogRepository.DeleteByIdAsync(blog.Id);
        return blog.Id;
    }
}