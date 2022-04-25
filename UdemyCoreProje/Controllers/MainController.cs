using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
