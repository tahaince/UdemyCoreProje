using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EFAboutDal());

        [HttpGet]
        public IActionResult EditAbout()
        {
            ViewBag.v1 = "Hakkımda Düzenle";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenle";

            var values = abm.TGetByID(4);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            abm.TUpdate(p);

            return RedirectToAction("Index","Default");
        }
    }
}
