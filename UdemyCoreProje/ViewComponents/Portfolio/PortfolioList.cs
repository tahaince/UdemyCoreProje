using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EFPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = pm.TGetList();
            return View(values);
        }
    }
}
