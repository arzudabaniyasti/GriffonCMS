using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Interests;
public class GetInterestDto : BaseDto<Guid>
{
    public string InterestName { get; set; }
    public string InterestContent { get; set; }
}
