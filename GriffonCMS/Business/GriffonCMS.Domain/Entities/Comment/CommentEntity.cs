using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Comments;
public class CommentEntity :AuditableBaseEntity<Guid>
{
    public Guid BlogId { get; set; }
    public string CommenterFullName { get; set; }
    public string CommenterMessage { get; set; }
    public string CommenterEMail { get; set; }
}
