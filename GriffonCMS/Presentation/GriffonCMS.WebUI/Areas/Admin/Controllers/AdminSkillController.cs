using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.Infrastructure.Command.Skills;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminSkillController : BaseController
{
    private IMediator _mediator;

    public AdminSkillController(ILogger<BaseController> logger, ISender sender, IMediator mediator) : base(logger, sender)
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
    public async Task<IActionResult> Index(CreateSkillCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction("Index", "AdminSkill", new { Area = "Admin" });
    }
}