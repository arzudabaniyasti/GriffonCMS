using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.StartPage;
public class StartPageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
