using System.Diagnostics;
using GriffonCMS.WebUI.Controllers.Base;
using GriffonCMS.WebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.PersonalBlog;
public class HomeController : BaseController
{
    public HomeController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}