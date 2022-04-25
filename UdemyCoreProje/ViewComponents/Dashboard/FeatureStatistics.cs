using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.skill = c.Skills.Count();
            ViewBag.message = c.Messages.Count(x => x.Status == false);
            ViewBag.experience = c.Experiences.Count();
            ViewBag.v4 = c.Portfolios.Count();
            
            //Ortalamayı getir...
            return View();
        }
    }
}
