using Microsoft.AspNetCore.Mvc;

namespace sparing.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
