using BusinessLayerT.Concrete;
using DataAccessLayerT.Concrete;
using DataAccessLayerT.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _WorkExperiencePartial:ViewComponent
    {
        WorkExperienceManager workExperienceManager = new WorkExperienceManager(new EfWorkExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = workExperienceManager.TGetList();
            return View(values);
        }
    }
}
