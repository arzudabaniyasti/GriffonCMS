using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers;
public class RegisterController : Controller
{
    public IActionResult Register()
    {
        return View();
    }
}
