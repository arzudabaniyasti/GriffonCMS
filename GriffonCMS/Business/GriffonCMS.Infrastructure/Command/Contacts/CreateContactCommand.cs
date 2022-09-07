using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Contacts;
public class CreateContactCommand : IRequest<Guid>
{
    public string ContactMail { get; set; }
    public string ContactName { get; set; }
    public string ContactMessage { get; set; }
}
