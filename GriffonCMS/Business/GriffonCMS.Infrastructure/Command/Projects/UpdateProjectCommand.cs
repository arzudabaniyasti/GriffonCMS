using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Projects;
public class UpdateProjectCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    //Technologies
    public string Description { get; set; }
    public Guid ImageId { get; set; }
}
