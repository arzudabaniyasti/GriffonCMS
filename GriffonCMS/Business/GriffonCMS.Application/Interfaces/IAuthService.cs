using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using GriffonCMS.Infrastructure.Utils.Results;
using GriffonCMS.Domain.Entities.Admin;

namespace GriffonCMS.Application.Interfaces;
public interface IAuthService
{
    IDataResult<Admin> Register(RegisterRequest registerRequest,string password);
    IDataResult<Admin> Login(LoginRequest loginRequest);
    IResult UserExists(string email);
    IDataResult<AccessToken> CreateAccessToken(Admin admin);

}
