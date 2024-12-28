using System.Web.Mvc;

namespace FitFormula.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Details()
        {
            return View();
        }
    }
}