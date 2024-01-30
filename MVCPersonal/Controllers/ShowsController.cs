using Microsoft.AspNetCore.Mvc;

namespace MVCPersonal.Controllers
{
	public class ShowsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
