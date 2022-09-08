using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Abouts;
public class GetAboutDto : BaseDto<Guid>
{
    public string Content { get; set; }
}
