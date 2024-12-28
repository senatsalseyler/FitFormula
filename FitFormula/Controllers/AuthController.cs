using System.Web.Mvc;
using FitFormula.Models;
using FirebaseAdmin.Auth;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace FitFormula.Controllers
{
    public class AuthController : Controller
    {
        private readonly FirebaseAuth _auth;

        public AuthController()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile("C:/Users/MSI/source/repos/FitFormula/FitFormula/fitformula-27ac5-firebase-adminsdk-c56nz-6fdf9b9242.json")
                });
            }
            _auth = FirebaseAuth.DefaultInstance;
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

        [HttpPost]
        public JsonResult VerifyToken(string token)
        {
            try
            {
                var decodedToken = _auth.VerifyIdTokenAsync(token).Result;
                Session["UserId"] = decodedToken.Uid;
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
    }
}