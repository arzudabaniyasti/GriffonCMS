using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class UserRepository : BaseRepository<UserEntity, Guid>, IUserRepository
{
    public UserRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }

}
