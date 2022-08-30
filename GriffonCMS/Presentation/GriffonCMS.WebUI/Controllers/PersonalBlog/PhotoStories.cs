using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.PersonalBlog;
public class PhotoStories : BaseController
{
    public PhotoStories(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
