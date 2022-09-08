using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Projects;
public class GetProjectDto : BaseDto<Guid>
{
    public DateTime Date { get; set; }

    public string Description { get; set; }
}
