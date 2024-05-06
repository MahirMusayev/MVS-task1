using Microsoft.AspNetCore.Mvc;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult>  Index()
        {
            return View();
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }
    }
}
