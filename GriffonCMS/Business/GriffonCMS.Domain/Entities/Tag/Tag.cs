using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Tag
{
    public class Tag : BaseEntity<Guid>
    {
        public string TagValue { get; set; }
    }
}
