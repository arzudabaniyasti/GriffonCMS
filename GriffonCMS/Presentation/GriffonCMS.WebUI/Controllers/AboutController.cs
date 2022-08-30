using Microsoft.AspNetCore.Mvc;

namespace CMS.UI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult About()
		{
			return View();
		}
	}
}
