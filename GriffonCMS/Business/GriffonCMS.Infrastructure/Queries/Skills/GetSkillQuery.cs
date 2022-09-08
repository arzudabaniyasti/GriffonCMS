using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Skills;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Skills;
public class GetSkillQuery : IRequest<List<GetSkillDto>>
{
}
