using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Dashboard
{
    public class ToDoListDashboard:ViewComponent
    {
        ToDoListManager tdm = new ToDoListManager(new EFTodoListDal());

        public IViewComponentResult Invoke()
        {
            var values = tdm.TGetList();
            return View(values);
        }

    }
}
