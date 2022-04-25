using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UdemyCoreProje.Areas.Writer.Models;

namespace UdemyCoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class RegisterrController : Controller
    {

        private readonly UserManager<WrriterUser> _userManager;

public RegisterrController(UserManager<WrriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]

        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task< IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WrriterUser w = new WrriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                    IamageUrl = p.ImageUrl,

                };

                var result = await _userManager.CreateAsync(w, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Writer");
                }
                else
                {
                    foreach(var x in result.Errors)
                    {
                        ModelState.AddModelError("", x.Description);
                    }
                }
            }


            return View();
        }
    }
}
