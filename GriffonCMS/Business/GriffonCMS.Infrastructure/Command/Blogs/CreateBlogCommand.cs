using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Comments;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Blogs;
public class CreateBlogCommand : IRequest<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
}
