using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminCategoryController : BaseController
{
    private IMediator _mediator;

    public AdminCategoryController(ILogger<BaseController> logger, ISender sender, IMediator mediator) : base(logger, sender)
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
    public async Task<IActionResult> Index(CreateCategoryCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction("Index", "AdminCategory", new { Area = "Admin" });
    }
}
