using System.Diagnostics;
using GriffonCMS.WebUI.Controllers.Base.Abstraction;
using GriffonCMS.WebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers.Base;
public class BaseController : Controller, IBaseController
{
    protected readonly ILogger<BaseController> _logger;
    protected readonly ISender _mediatr;

    public BaseController(ILogger<BaseController> logger, ISender sender)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mediatr = sender ?? throw new ArgumentNullException(nameof(sender));
    }
}