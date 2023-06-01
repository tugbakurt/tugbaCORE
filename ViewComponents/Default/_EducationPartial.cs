using BusinessLayerT.Concrete;
using DataAccessLayerT.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _EducationPartial:ViewComponent
    {
        EducationManager educationManager = new EducationManager(new EfEducationDal());
        public IViewComponentResult Invoke()
        {
            var values = educationManager.TGetList();
                return View(values);
        }  
    }
}
