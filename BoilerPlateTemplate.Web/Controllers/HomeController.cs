using System.Web.Mvc;

namespace BoilerPlateTemplate.Web.Controllers
{
    public class HomeController : BoilerPlateTemplateControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}