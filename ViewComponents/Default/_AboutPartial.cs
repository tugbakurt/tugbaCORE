using BusinessLayerT.Concrete;
using DataAccessLayerT.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {

            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
