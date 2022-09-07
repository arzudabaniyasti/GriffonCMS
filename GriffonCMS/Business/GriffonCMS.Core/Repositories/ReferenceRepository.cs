using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class ReferenceRepository : BaseRepository<ReferenceEntity, Guid>, IReferenceRepository
{
    public ReferenceRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }

}
