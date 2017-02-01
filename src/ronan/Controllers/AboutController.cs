using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View("About");
        }
    }
}
