using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager exm = new ExperienceManager(new EFExperienceDal()); 
        public IViewComponentResult Invoke()
        {
            var values = exm.TGetList();
            return View(values);
        }
    }
}
