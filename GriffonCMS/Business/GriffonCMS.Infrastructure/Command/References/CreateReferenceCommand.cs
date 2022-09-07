using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.References;
public class CreateReferenceCommand : IRequest<Guid>
{
    public string ReferenceFullName { get; set; }
    public string ReferenceReview { get; set; }
    public Guid ImageId { get; set; }
    public string Job { get; set; }
}
