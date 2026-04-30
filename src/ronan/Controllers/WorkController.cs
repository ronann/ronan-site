using Microsoft.AspNetCore.Mvc;

namespace ronan.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index() => Redirect("/#work");
    }
}
