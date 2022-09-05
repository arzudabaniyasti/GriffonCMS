using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Repositories.Base.Abstract;

namespace GriffonCMS.Infrastructure.DTOS.Account;
public class LoginRequest : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}
