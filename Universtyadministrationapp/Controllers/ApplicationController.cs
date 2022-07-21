using Microsoft.AspNetCore.Mvc;

namespace Universtyadministrationapp.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Application()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
