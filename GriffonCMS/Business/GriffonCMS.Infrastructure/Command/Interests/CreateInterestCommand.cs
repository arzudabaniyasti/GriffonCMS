using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Interests;
public class CreateInterestCommand : IRequest<Guid>
{
    public string InterestName { get; set; }
    public string InterestContent { get; set; }
}
