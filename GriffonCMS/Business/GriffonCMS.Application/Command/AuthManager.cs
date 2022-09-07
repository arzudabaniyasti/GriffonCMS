using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Application.Interfaces;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.Infrastructure.Utils.Results;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using MediatR;


namespace GriffonCMS.Application.Command;
public class AuthManager : IAuthService
{
    IAdminService _adminService;
    IUserRepository _userRepository;
    ITokenHelper _tokenHelper;
    private readonly IMapper _mapper;
    public AuthManager(IAdminService adminService, ITokenHelper tokenHelper, IUserRepository userRepository, IMapper mapper)
    {
        _adminService = adminService;
        _tokenHelper = tokenHelper;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public IDataResult<AccessToken> CreateAccessToken(AdminEntity admin)
    {
        var accessToken = _tokenHelper.CreateToken(admin);
        return new SuccessDataResult<AccessToken>(accessToken,"Access token created");
    }

    public IDataResult<AdminEntity> Login(LoginRequest loginRequest)
    {
        var adminToCheck = _adminService.GetByMail(loginRequest.Email);
        if (adminToCheck == null)
        {
            return new ErrorDataResult<AdminEntity>("email eşleşmedi user not found");
        }
        if(!(adminToCheck.Password == loginRequest.Password))
        {
            return new ErrorDataResult<AdminEntity>("Password eşleşmedi");
        }
        return new SuccessDataResult<AdminEntity>(adminToCheck,"Login success");

    }

    public IDataResult<AdminEntity> Register(RegisterRequest registerRequest)
    {
        var admin = new AdminEntity
        {
            EMail = registerRequest.Email,
            FullName = registerRequest.FullName,
            Password = registerRequest.Password
        };
        _adminService.AddAsync(admin);
        var user = new UserEntity
        {
            AdminId = admin.Id
        };

        _userRepository.AddAsync(user);

        return new SuccessDataResult<AdminEntity>(admin,"register success");
    }

    //public IDataResult<AdminEntity> Register(RegisterRequest registerRequest, string password)
    //{
    //    var admin = new AdminEntity
    //    {
    //        EMail = registerRequest.Email,
    //        FullName = registerRequest.FullName,
    //        Password = password
    //    };
    //    _adminService.AddAsync(admin);
    //    return new SuccessDataResult<AdminEntity>(admin, "register success");
    //}

    public IResult UserExists(string email)
    {
        if (_adminService.GetByMail(email) != null)
        {
            return new ErrorResult("User Already Exist");
        }
        return new SuccessResult(true,"success exists değil");
    }
}
