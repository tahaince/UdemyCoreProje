using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager pm = new FeatureManager(new EFFeatureDal());

        [HttpGet]
        public IActionResult EditFeature()
        {
            ViewBag.v1 = "Öne Çıkanlar Düzenle";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Düzenle";

            var values = pm.TGetByID(1);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditFeature(Feature p)
        {
            pm.TUpdate(p);

            return RedirectToAction("Index","Default");
        }
    }
}
