using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Home");
    }
}
