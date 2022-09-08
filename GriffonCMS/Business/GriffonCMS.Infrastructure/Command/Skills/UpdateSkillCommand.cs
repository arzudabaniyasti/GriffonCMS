using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Skills;
public class UpdateSkillCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string SkillName { get; set; }
    public int SkillLevel { get; set; }
}
