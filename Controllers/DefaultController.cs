using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
