using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class AdminRepository : BaseRepository<AdminEntity, Guid>,IAdminRepository
{
    public AdminRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }
}
