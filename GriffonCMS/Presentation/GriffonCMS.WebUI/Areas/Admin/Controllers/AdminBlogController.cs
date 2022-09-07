using GriffonCMS.Application.Interfaces;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminBlogController : BaseController
{

    public AdminBlogController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }
    
    public IActionResult Index()
    {
        return View();
    }


}