using GriffonCMS.Application.Interfaces;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Blogs;
using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.Infrastructure.DTOS.Account;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminBlogController : BaseController
{

    private IMediator _mediator;

    public AdminBlogController(ILogger<BaseController> logger, ISender sender, IMediator mediator) : base(logger, sender)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Index(CreateBlogCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction("Index", "AdminBlog", new { Area = "Admin" });
    }
}