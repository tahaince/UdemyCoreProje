
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }


        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }

        public PartialViewResult NewSideBarPartial()
        {
            return PartialView();
        }

    }
}
