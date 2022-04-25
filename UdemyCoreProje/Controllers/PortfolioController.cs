using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EFPortfolioDal()); 
        public IActionResult Index()
        {
            ViewBag.v1 = "Projeleri Listele";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Projeleri Listele";
            var values = pm.TGetList();

            return View(values);
        }


        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Projeleri Listele";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Projeleri Listele";
            return View();
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if(result.IsValid)
            {
                pm.TAdd(p);
                
                return RedirectToAction("Index");
            }

            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeletePortfolio(int id)
        {

            var values = pm.TGetByID(id);
            pm.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Projeleri Listele";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Projeleri Listele";

            var values = pm.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            pm.TUpdate(p);

            return RedirectToAction("Index");
        }


    }
}
