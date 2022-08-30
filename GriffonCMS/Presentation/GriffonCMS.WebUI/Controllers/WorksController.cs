using Microsoft.AspNetCore.Mvc;

namespace CMS.UI.Controllers
{
	public class WorksController : Controller
	{
		public IActionResult Works()
		{
			return View();
		}
	}
}
