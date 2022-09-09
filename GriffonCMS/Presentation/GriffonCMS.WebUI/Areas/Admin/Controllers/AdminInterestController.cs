using GriffonCMS.Infrastructure.Command.Interests;
using GriffonCMS.Infrastructure.Command.Skills;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminInterestController : BaseController
{

    private IMediator _mediator;

    public AdminInterestController(ILogger<BaseController> logger, ISender sender, IMediator mediator) : base(logger, sender)
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
    public async Task<IActionResult> Index(CreateInterestCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction("Index", "AdminInterest", new { Area = "Admin" });
    }
}