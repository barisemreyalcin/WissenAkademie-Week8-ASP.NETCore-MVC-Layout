using Microsoft.AspNetCore.Mvc;

namespace LayoutSample.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult BoardOfDirectors()
		{
			return View();
		}

		public IActionResult History()
		{
			return View();
		}
	}
}
