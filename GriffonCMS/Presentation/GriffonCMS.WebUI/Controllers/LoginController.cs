using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers;
public class LoginController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
