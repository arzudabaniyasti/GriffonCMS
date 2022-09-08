using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.References;
public class UpdateReferenceCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string ReferenceFullName { get; set; }
    public string ReferenceReview { get; set; }
    public Guid ImageId { get; set; }
    public string Job { get; set; }
}