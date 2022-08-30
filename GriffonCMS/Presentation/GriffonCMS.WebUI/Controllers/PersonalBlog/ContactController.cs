using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.PersonalBlog
{
    public class ContactController : BaseController
    {
        public ContactController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
        {
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
