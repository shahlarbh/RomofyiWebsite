using Microsoft.AspNetCore.Mvc;

namespace RomofyiWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
