using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class LoginController : Controller
    {
        private readonly SignInManager<WrriterUser> _signInManager;

        public LoginController(SignInManager<WrriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
