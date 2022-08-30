using Microsoft.AspNetCore.Mvc;

namespace CMS.UI.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult News()
		{
			return View();
		}
	}
}
