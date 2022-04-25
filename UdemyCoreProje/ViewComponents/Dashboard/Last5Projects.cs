using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {

            var values = pm.TGetList().TakeLast(5).ToList();
            return View(values);
        }
    }
}
