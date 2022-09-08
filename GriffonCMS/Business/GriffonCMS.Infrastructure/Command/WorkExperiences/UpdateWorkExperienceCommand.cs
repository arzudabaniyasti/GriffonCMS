using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.WorkExperiences;
public class UpdateWorkExperienceCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Role { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
}