using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Core.Repositories;
public class TagRepository : BaseRepository<TagEntity, Guid>, ITagRepository
{
    public TagRepository(GriffonEFContext dbContext) : base(dbContext)
    {
    }
}
