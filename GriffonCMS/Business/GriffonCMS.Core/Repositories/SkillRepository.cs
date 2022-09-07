using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class SkillRepository : BaseRepository<SkillEntity, Guid>, ISkillRepository
{
    public SkillRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }

}
