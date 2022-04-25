using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.TestimonialList
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = tm.TGetList();
            return View(values);

        }
    }
}
