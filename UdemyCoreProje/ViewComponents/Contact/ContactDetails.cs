using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager cm = new ContactManager(new EFContactDal()); 

        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
