using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Dashboard
{
    public class MessageDashboard:ViewComponent
    {
        UserMessageManager msg = new UserMessageManager(new EFUserMessageDal());

        public IViewComponentResult Invoke()
        {
            var values = msg.GetUserMessageWithUserService();
            return View(values);
        }

    }
}
