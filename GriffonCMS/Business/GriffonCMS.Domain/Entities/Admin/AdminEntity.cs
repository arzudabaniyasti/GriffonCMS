using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Admin;
public class AdminEntity : BaseEntity<Guid>
{
    
    public string FullName { get; set; }
    public string EMail { get; set; }
    public string Password { get; set; }

}
