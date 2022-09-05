using GriffonCMS.Application.Interfaces;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class LoginController : BaseController
{
    private IAuthService _authService;
    public LoginController(ILogger<BaseController> logger, ISender sender, IAuthService authService) : base(logger, sender)
    {
        _authService = authService;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var adminToLogin = _authService.Login(loginRequest);
        if (!adminToLogin.Success)
        {
            return View();
        }
        var result = _authService.CreateAccessToken(adminToLogin.Data);
        if (result.Success)
        {
            return RedirectToAction("Index", "DashBoard",new { Area = "Admin" });
        }
        return View();
    }
}
