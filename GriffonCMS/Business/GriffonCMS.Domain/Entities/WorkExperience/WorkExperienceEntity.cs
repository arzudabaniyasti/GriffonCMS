using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.WorkExperience;
public class WorkExperienceEntity: BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Role { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
}
