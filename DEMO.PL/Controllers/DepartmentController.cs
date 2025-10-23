using AspNetCoreGeneratedDocument;
using DEMO.BLL.DTOs.DepartmentDtos;
using DEMO.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DEMO.PL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService , ILogger<HomeController> _logger , IWebHostEnvironment _environment) : Controller


    {

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto departmentDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int res = _departmentService.AddDepartment(departmentDto);
                    if (res > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Can't Be Added");
                        return View(departmentDto);
                    }
                }

                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);

                        return View(departmentDto);
                    }
                    else
                    {
                        return View(departmentDto);
                    }
                }

            }
            else return View(departmentDto);
        }

        [HttpGet] 
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var department = _departmentService.GetById(id.Value);
            if (department is null) return NotFound();

            else
            {
                return View(department);
            }
                
        }
    }
}
