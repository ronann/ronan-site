using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class WorkController : Controller
    {
        public ActionResult Index()
        {
            return View("Work");
        }
    }
}
