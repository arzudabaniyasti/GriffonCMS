using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.Admin;
public class DashboardController : BaseController
{
    public DashboardController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
