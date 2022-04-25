using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
