using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Admins;
public class GetAdminDto : BaseDto<Guid>
{
    public int AdminId { get; set; }
    public string FullName { get; set; }
    public string EMail { get; set; }
    public string Password { get; set; }
}
