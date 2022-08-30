using Microsoft.AspNetCore.Mvc;

namespace CMS.UI.Controllers
{
	public class ResumeController : Controller
	{
		public IActionResult Resume()
		{
			return View();
		}
	}
}
