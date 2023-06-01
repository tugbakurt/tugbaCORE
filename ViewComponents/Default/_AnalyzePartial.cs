using DataAccessLayerT.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _AnalyzePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Skills.Count();
            return View();
        }
    }
}
