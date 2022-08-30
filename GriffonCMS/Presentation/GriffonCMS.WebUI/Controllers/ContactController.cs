using Microsoft.AspNetCore.Mvc;

namespace CMS.UI.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Contact()
		{
			return View();
		}
	}
}
