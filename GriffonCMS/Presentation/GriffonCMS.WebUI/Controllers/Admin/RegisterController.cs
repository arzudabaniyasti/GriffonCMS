using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.Admin;
public class RegisterController : BaseController
{
    public RegisterController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Register()
    {
        return View();
    }
}
