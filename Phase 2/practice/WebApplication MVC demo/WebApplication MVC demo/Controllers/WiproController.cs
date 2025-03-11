using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MVC_demo.Controllers
{
    public class WiproController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
