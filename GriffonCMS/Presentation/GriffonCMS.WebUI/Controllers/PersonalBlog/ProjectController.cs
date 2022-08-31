using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.PersonalBlog;
public class ProjectController : BaseController
{

public ProjectController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Details()
    {
        return View();
    }
}
