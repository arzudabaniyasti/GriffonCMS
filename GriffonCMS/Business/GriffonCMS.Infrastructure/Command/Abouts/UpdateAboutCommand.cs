using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Abouts;
public class UpdateAboutCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public Guid ImageId { get; set; }
}
