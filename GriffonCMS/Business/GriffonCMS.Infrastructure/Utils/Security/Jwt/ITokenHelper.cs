using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Admin;

namespace GriffonCMS.Infrastructure.Utils.Security.Jwt;
public interface ITokenHelper
{
    AccessToken CreateToken(AdminEntity Admin);
    //token üretimi gerçekleştirecek helper
}
