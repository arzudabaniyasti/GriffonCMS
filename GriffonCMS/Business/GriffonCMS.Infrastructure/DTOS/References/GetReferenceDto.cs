using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.References;
public class GetReferenceDto : BaseDto<Guid>
{
    public string ReferenceFullName { get; set; }
    public string ReferenceReview { get; set; }
    public Guid ImageId { get; set; }
    public string Job { get; set; }
}
