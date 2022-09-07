using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Category;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Projects;
public class CreateProjectCommand : IRequest<Guid>
{
    public DateTime Date { get; set; }

    public string Description { get; set; }
}
