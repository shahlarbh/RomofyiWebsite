using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
