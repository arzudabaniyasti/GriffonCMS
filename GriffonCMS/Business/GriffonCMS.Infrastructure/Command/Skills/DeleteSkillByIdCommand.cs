using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Skills;
public class DeleteSkillByIdCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
}