using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EFSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listele";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Listele";
            var values = sm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {

            ViewBag.v1 = "Yetenek Ekle";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Ekle";
            return View();
        }


        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {

            ViewBag.v1 = "Yetenek Sil";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Sil";

            var values = sm.TGetByID(id);
            sm.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Yetenek Düzenle";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Düzenle";

            var values = sm.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            sm.TUpdate(p);

            return RedirectToAction("Index");
        }

    }
}
