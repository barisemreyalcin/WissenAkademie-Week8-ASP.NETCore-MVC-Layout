using Microsoft.AspNetCore.Mvc;

namespace LayoutSample.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult TrumpAssassination()
		{
			return View();
		}

		public IActionResult MarketDownturn()
		{
			return View();
		}
	}
}
