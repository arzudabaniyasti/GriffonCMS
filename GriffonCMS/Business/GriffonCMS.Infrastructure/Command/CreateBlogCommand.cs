using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Comments;
using MediatR;

namespace GriffonCMS.Infrastructure.Command;
public class CreateBlogCommand : IRequest<Guid>
{
    public Guid CategoryId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}
