using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager exm = new ExperienceManager(new EFExperienceDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listele";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Listele";
            var values = exm.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Listele";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Listele";
            return View();
        }


        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            exm.TAdd(experience);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteExperience(int id)
        {
            var values = exm.TGetByID(id);
            exm.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Deneyim Düzenle";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Düzenle";

            var values = exm.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            exm.TUpdate(p);

            return RedirectToAction("Index");
        }
    }
}
