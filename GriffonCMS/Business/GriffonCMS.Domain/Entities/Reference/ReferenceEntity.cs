using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Reference;
public class ReferenceEntity : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string ReferenceFullName { get; set; }
    public string ReferenceReview { get; set; }
    public Guid ImageId { get; set; }
    public string Job { get; set; }


}
