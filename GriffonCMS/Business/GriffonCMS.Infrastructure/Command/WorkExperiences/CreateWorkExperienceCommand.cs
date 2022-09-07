using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.WorkExperiences;
public class CreateWorkExperienceCommand : IRequest<Guid>
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Role { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
}
