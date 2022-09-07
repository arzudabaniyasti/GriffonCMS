using GriffonCMS.Application.Interfaces;
using GriffonCMS.Infrastructure.DTOS.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpPost("login")]
    public ActionResult Login(LoginRequest loginRequest)
    {
        var adminToLogin = _authService.Login(loginRequest);
        if (!adminToLogin.Success)
        {
            return BadRequest(adminToLogin.Message);
        }
        var result = _authService.CreateAccessToken(adminToLogin.Data);
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("register")]
    public ActionResult Register(RegisterRequest registerRequest)
    {
        var userExists = _authService.UserExists(registerRequest.Email);
       
        if (!userExists.Success)
        {
            return BadRequest(userExists.Message);
        }
        var registerResult = _authService.Register(registerRequest);
        var result = _authService.CreateAccessToken(registerResult.Data);
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }
}
