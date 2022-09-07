using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Application.Interfaces;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.Infrastructure.Utils.Results;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;


namespace GriffonCMS.Application.Command;
public class AuthManager : IAuthService
{
    IAdminService _adminService;
    ITokenHelper _tokenHelper;
    public AuthManager(IAdminService adminService, ITokenHelper tokenHelper)
    {
        _adminService = adminService;
        _tokenHelper = tokenHelper;
    }

    public IDataResult<AccessToken> CreateAccessToken(Admin admin)
    {
        var accessToken = _tokenHelper.CreateToken(admin);
        return new SuccessDataResult<AccessToken>(accessToken,"Access token created");
    }

    public IDataResult<Admin> Login(LoginRequest loginRequest)
    {
        var adminToCheck = _adminService.GetByMail(loginRequest.Email);
        if (adminToCheck == null)
        {
            return new ErrorDataResult<Admin>("email eşleşmedi user not found");
        }
        if(!(adminToCheck.Password == loginRequest.Password))
        {
            return new ErrorDataResult<Admin>("Password eşleşmedi");
        }
        return new SuccessDataResult<Admin>(adminToCheck,"Login success");

    }

    public IDataResult<Admin> Register(RegisterRequest registerRequest)
    {
        var admin = new Admin
        {
            EMail = registerRequest.Email,
            FullName = registerRequest.FullName,
            Password = registerRequest.Password
        };
        _adminService.AddAsync(admin);
        return new SuccessDataResult<Admin>(admin,"register success");
    }

    public IDataResult<Admin> Register(RegisterRequest registerRequest, string password)
    {
        var admin = new Admin
        {
            EMail = registerRequest.Email,
            FullName = registerRequest.FullName,
            Password = password
        };
        _adminService.AddAsync(admin);
        return new SuccessDataResult<Admin>(admin, "register success");
    }

    public IResult UserExists(string email)
    {
        if (_adminService.GetByMail(email) != null)
        {
            return new ErrorResult("User Already Exist");
        }
        return new SuccessResult(true,"success exists değil");
    }
}
