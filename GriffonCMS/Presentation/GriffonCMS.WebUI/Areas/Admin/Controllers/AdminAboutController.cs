using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminAboutController : BaseController
{
    private IMediator _mediator;

    public AdminAboutController(ILogger<BaseController> logger, ISender sender, IMediator mediator) : base(logger, sender)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(CreateAboutCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction("Index", "AdminAbout", new { Area = "Admin" });
    }
}