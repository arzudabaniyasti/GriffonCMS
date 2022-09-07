using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.About;
public class AboutEntity:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string Content { get; set; }
    public Guid ImageId { get; set; }
}
