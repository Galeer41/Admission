using Microsoft.AspNetCore.Mvc;

namespace Universtyadministrationapp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
