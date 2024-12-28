using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace FitFormula.Controllers
{
    public class AuthController : Controller
    {
        public AuthController()
        {
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}