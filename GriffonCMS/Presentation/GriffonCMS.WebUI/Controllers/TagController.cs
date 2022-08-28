using GriffonCMS.Infrastructure.Queries.Tags;
using GriffonCMS.WebUI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GriffonCMS.WebUI.Controllers;
public class TagController : BaseController
{
    public TagController(ILogger<BaseController> logger, ISender sender) : base(logger, sender)
    {
    }

    public async Task<JsonResult> Index()
    {
        try
        {
            var result = await _mediatr.Send(new GetTagQuery());
            return Json(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
