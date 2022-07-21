using Microsoft.AspNetCore.Mvc;

namespace Universtyadministrationapp.Controllers
{
	public class RegistrationController : Controller
	{
		public IActionResult Registration()
		{
			return View();
		}
	}
}
