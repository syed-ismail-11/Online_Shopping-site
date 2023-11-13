using Microsoft.AspNetCore.Mvc;

namespace Online_Shopping_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
