using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.Base;
using GriffonCMS.Domain.Entities.Comments;

namespace GriffonCMS.Domain.Entities.Blog;
public class BlogEntity : AuditableBaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public virtual ICollection <CommentEntity> Comments {get;set;}
    public string Title { get; set; }
    public string Content { get; set; }
}
