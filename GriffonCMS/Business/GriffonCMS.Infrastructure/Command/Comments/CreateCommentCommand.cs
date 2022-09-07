using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Comments;
public class CreateCommentCommand : IRequest<Guid>
{
    public Guid BlogId { get; set; }
    public string CommenterFullName { get; set; }
    public string CommenterMessage { get; set; }
    public string CommenterEMail { get; set; }
}
