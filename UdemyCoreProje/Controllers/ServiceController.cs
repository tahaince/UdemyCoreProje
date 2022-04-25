using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager sm = new ServiceManager(new EFServiceDal());
        public IActionResult Index()
        {
            var values = sm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {

            ViewBag.v1 = "Hizmet Ekle";
            ViewBag.v2 = "Hizmet";
            ViewBag.v3 = "Hizmet Ekle";
            return View();
        }


        [HttpPost]
        public IActionResult AddService(Service p)
        {

            sm.TAdd(p);

            return RedirectToAction("Index");
        }




        public IActionResult DeleteService(int id)
        {

            var values = sm.TGetByID(id);
            sm.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Portfolio Düzenle";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "Portfolio Düzenle";

            var values = sm.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditService(Service p)
        {
            sm.TUpdate(p);

            return RedirectToAction("Index");
        }



    }
}
