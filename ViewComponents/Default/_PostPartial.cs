using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.ViewComponents.Default
{
    public class _PostPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            //todo: db ayarla 
            return View(); 
        }  
    }
}
