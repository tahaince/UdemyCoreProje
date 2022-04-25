using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager sm = new SkillManager(new EFSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = sm.TGetList();
            return View(values);
        }
    }
}
