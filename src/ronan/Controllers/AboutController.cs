using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index() => Redirect("/#about");
    }
}
