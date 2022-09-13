using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Infrastructure.DTOS.Users;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using WebApi.Models;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]

public class JWTTokenController : ControllerBase
{
    public IConfiguration _configuration;
    public readonly GriffonEFContext _context;

    public JWTTokenController(GriffonEFContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<IActionResult> Post (AdminEntity admin)
    {
        if(admin!=null && admin.FullName!=null&& admin.Password != null)
        {
            var adminData = await GetUser(admin.FullName, admin.Password);
            var jwt = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
            if (admin != null)
            {
                var claims = new[]
                {
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                    new Claim("Id",admin.Id.ToString()),
                    new Claim("FullName",admin.FullName),
                    new Claim("Password",admin.Password)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecurityKey));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    jwt.Issuer, jwt.Audience, claims, expires: DateTime.Now.AddMinutes(20), signingCredentials: signIn);
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
            {
                return BadRequest("Invalid Credentials");
            }
        }
        else
        {
            return BadRequest("Invalid Credentials");
        }
    }

    [HttpGet]
    private async Task<AdminEntity> GetUser(string userName, string password)
    {
        return await _context.Admin.FirstOrDefaultAsync(u => u.FullName == userName && u.Password == password);

    }
}
