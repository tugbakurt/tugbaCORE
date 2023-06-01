using BusinessLayerT.Concrete;
using DataAccessLayerT.EntityFramework;
using EntityLayerT.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tugbaCORE.Controllers
{
    public class EducationController : Controller
    {
        EducationManager educationManager = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            var values=educationManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult EducationDetails(int id)
        {
            var values=educationManager.TGetById(id);
            return View(values);
        }
        [HttpPost]  
        public IActionResult EducationDetails(Education p)
        {
            return View(p);
        }
    }
}
