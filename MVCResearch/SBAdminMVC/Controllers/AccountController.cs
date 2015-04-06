using System.Web.Mvc;

namespace SBAdminMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logoff()
        {
            return View();
        }
    }
}