using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Skills;
public class GetSkillDto : BaseDto<Guid>
{
    public string SkillName { get; set; }
    public int SkillLevel { get; set; }
}
