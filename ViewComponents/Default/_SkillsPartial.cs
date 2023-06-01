using BusinessLayerT.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _SkillsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
