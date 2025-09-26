using DEMO.BLL;
using Microsoft.AspNetCore.Mvc;

namespace DEMO.PL.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentController(DepartmentService departmentService) // call service
        {
            
        } // ask CLR create object from departmentService


        public IActionResult Index()
        {
            return View();
        }
    }
}
