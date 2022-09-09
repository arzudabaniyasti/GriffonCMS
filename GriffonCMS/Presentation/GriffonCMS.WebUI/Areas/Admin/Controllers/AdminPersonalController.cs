using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminPersonalController : BaseController
{
    public AdminPersonalController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
