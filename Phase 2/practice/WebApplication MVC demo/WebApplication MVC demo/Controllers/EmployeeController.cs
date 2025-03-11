using Microsoft.AspNetCore.Mvc;
using WebApplication_MVC_demo.Models;

namespace WebApplication_MVC_demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult empdetails()
        {
            return View();
        }
        public IActionResult details()
        {
            return View();
        }
        public IActionResult empdelete()
        {
            return View();
        }

        public IActionResult empList()
        {
            List<Employee> obj = new List<Employee>
                                {
                                    new Employee {Id=101,FirstName="aa",LastName="bb",city="Delhi", phone=13432 },
                                    new Employee {Id=102,FirstName="aa",LastName="bb",city="Delhi", phone=13432 },
                                    new Employee {Id=103,FirstName="aa",LastName="bb",city="Delhi", phone=13432 },
                                    new Employee {Id=104,FirstName="aa",LastName="bb",city="Delhi", phone=13432 },
                                    new Employee {Id=105,FirstName="aa",LastName="bb",city="Delhi", phone=13432 }
                                 };
            return View(obj);
        }
    }
}
