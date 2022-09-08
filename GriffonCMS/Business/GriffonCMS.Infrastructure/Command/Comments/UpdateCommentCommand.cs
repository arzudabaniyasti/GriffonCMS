using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Comments;
public class UpdateCommentCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string CommenterFullName { get; set; }
    public string CommenterMessage { get; set; }
    public string CommenterEMail { get; set; }
}
