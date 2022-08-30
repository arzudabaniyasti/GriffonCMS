using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.Admin;
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
