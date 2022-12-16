using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
	public class WebsiteController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
		public IActionResult Courses()
		{
			return View();
		}
	}
}
