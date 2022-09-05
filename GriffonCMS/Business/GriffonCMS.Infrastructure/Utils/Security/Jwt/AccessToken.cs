using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonCMS.Infrastructure.Utils.Security.Jwt;
public class AccessToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
    //refresh token ekleyebilirsin istersen
}
