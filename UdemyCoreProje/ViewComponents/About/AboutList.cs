using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager abm = new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = abm.TGetList();
            return View(values);
        }
    }
}
