using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.WorkExperiences;
public class GetWorkExperienceDto : BaseDto<Guid>
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Role { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
}
