using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Contacts;
public class UpdateContactCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string ContactMail { get; set; }
    public string ContactName { get; set; }
    public string ContactMessage { get; set; }
}
