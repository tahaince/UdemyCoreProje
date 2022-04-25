using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager sm = new ServiceManager(new EFServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = sm.TGetList();

            return View(values);
        }
    }
}
