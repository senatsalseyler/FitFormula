using System.Web.Mvc;

namespace FitFormula.Controllers
{
    public class AuthController : Controller
    {
        public AuthController()
        {
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
    }
}