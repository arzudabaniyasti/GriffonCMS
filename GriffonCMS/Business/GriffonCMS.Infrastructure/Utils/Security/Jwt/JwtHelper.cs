using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using GriffonCMS.Infrastructure.Utils.Security.Encryption;
using GriffonCMS.Domain.Entities.Admin;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using GriffonCMS.Infrastructure.Extensions;

namespace GriffonCMS.Infrastructure.Utils.Security.Jwt;
public class JwtHelper : ITokenHelper
{
    //configuration dosyasında bizim token options diye bir alanımız olacak
    public IConfiguration _configuration { get; }
    private TokenOptions _tokenOptions;
    DateTime _accessTokenExpirations;
    //constructor
    public JwtHelper(IConfiguration configuration)
    {
        _configuration = configuration;
        _tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        _accessTokenExpirations = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
    }
    public AccessToken CreateToken(AdminEntity admin)
    {
        var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        var signingCredentials=SigningCredentialsHelper.CreateSigningCredentials(securityKey);
        var jwt = CreateJwtSecurityToken(_tokenOptions, admin, signingCredentials);
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var token = jwtSecurityTokenHandler.WriteToken(jwt);
        return new AccessToken
        {
            Token = token,
            Expiration = _accessTokenExpirations
        };
    }
    //tokenın expiration süresi şuandan önceyse geçerli değil notBefore
    public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,AdminEntity admin,SigningCredentials signingCredentials)
    {
        var jwt= new JwtSecurityToken(
            issuer: tokenOptions.Issuer,
            audience: tokenOptions.Audience,
            expires: _accessTokenExpirations,
            notBefore: DateTime.Now,
            signingCredentials: signingCredentials
        );
        return jwt;
    }
    private IEnumerable<Claim> SetClaims(AdminEntity admin)
    {
        var claims = new List<Claim>();
        claims.AddNameIdentifier(admin.Id.ToString());
        claims.AddEmail(admin.EMail);
        claims.AddName(admin.FullName);
        //role ekleyebilirsin 
        return claims;
    }

}
