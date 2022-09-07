using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class AboutRepository : BaseRepository<AboutEntity, Guid>, IAboutRepository
{
    public AboutRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }

}
