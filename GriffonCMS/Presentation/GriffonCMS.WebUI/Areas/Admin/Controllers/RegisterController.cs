using GriffonCMS.Application.Interfaces;
using GriffonCMS.Application.Command.Admins;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class RegisterController : BaseController
{
    private IAuthService _authService;

    public RegisterController(ILogger<BaseController> logger, ISender sender, IAuthService authService) : base(logger, sender)
    {
        _authService = authService;
    }
    [HttpGet]//sayfa yüklenince çalışır
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]//buton basılınca çalışır
    public IActionResult Register(RegisterRequest registerRequest)
    {
        var userExists = _authService.UserExists(registerRequest.Email);

        if (!userExists.Success)
        {
            return View();
        }
        var registerResult = _authService.Register(registerRequest);
        var result = _authService.CreateAccessToken(registerResult.Data);
        if (result.Success)
        {
            return RedirectToAction("Login", "Login", new { Area = "Admin" });
        }
        return View();
    }

}
