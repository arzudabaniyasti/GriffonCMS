using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;
using GriffonCMS.Domain.Entities.Category;

namespace GriffonCMS.Domain.Entities.Skill;
public class SkillEntity:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    //Skill type language vs.
    public ICollection<CategoryEntity> Categories { get; set; }
    public string SkillName { get; set; }
    public int SkillLevel { get; set; }
}
