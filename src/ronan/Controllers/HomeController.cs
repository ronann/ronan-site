using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Home");
        }
    }
}
