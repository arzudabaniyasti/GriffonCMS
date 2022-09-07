using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class InterestRepository : BaseRepository<InterestEntity, Guid>, IInterestRepository
{
    public InterestRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }

}
