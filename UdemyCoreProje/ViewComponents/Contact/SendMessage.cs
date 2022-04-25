using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager ms = new MessageManager(new EFMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            var values = ms.TGetList();
            return View(values);

        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    ms.TAdd(p);
        //    return View();

        //}
    }
}
