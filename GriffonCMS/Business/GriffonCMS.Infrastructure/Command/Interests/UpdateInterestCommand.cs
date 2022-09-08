using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Interests;
public class UpdateInterestCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string InterestName { get; set; }
    public string InterestContent { get; set; }
    public Guid ImageId { get; set; }
}
