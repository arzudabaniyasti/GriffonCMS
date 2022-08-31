using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.PersonalBlog
{
    public class AboutController : BaseController
    {
        public AboutController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
        {
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
