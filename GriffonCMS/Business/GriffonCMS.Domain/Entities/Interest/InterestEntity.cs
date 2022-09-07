using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Interest;
public class InterestEntity:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string InterestName { get; set; }
    public string InterestContent { get; set; }
    public Guid ImageId { get; set; }

}
