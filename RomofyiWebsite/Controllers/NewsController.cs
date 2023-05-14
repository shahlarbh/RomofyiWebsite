using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
