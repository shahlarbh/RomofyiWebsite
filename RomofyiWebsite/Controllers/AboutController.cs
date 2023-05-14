using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
