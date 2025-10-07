using Microsoft.AspNetCore.Mvc;
using MVC_CoreApp1.Models;

namespace MVC_CoreApp1.Controllers
{
    public class EmployController : Controller
    {
        public IActionResult Index()
        {
            Employ emp = new Employ()
            {
                Id = 1,
                Name = "Pandu",
                Salary = 99999
            };

            return View(emp);
        }
    }
}
