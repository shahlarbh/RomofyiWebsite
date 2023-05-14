using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class FashionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
