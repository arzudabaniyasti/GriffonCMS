using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Users;
public class GetUserDto : BaseDto<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Birthday { get; set; }
    public int Age { get; set; }
    public string CVLink { get; set; }
    public string Job { get; set; }
    public string Address { get; set; }
}
