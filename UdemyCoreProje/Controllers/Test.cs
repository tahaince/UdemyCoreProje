using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
