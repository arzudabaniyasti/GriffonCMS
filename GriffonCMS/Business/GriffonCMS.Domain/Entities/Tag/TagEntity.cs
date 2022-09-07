using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Tag
{
    public class TagEntity : BaseEntity<Guid>
    {
        public string TagValue { get; set; }
        
    }
}
