using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Skills;
public class CreateSkillCommand : IRequest<Guid>
{
    public string SkillName { get; set; }
    public int SkillLevel { get; set; }
}
