using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class CategoryRepository : BaseRepository<Category, Guid>, ICategoryRepository
{
    public CategoryRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }
}
