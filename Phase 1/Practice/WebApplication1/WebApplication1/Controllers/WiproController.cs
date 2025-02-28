using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class WiproController : Controller
    {
        public IActionResult Index(int? id=null)
        {
            if(id.HasValue)
            {
                if(id==1)
                {
                    throw new FileNotFoundException("File not Found exception thrown in index.cshtml");
                }
                else if(id==2)
                {
                    return StatusCode(500);
                }
            }
            return View();
        }
    }
}
