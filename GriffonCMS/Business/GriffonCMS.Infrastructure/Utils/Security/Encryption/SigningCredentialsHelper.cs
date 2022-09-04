using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace GriffonCMS.Infrastructure.Utils.Security.Encryption;
public class SigningCredentialsHelper
{
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
    {
        //BURDA KULLANDIĞIN ALGORİTMA ENCRYPE EDİLEN DATANIN NASIL ENCRYPTE EDİLDİĞİ İLE İLGİLİ
        return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
    }
}
