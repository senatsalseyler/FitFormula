using Firebase.Database;
using System.Threading.Tasks;
using System.Web.Mvc;

public class ProfileController : Controller
{
    private readonly string _firebaseDatabaseUrl = "https://fitformula-27ac5-default-rtdb.firebaseio.com/";

    [HttpGet]
    public ActionResult UserSetup()
    {
        if (Session["AuthToken"] == null)
            return RedirectToAction("Login", "Auth");
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> UserSetup(string username, int calorieGoal)
    {
        var client = new FirebaseClient(_firebaseDatabaseUrl);
        var auth = Session["AuthToken"].ToString();

        var user = new UserModel
        {
            Username = username,
            CalorieGoal = calorieGoal
        };

        await client
            .Child("users")
            .Child(auth.User.LocalId)
            .PutAsync(user);

        return RedirectToAction("Index", "Home");
    }
}
