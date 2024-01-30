using Microsoft.AspNetCore.Mvc;

namespace MVCPersonal.Controllers
{
	public class PeopleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
