using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
