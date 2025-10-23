using DEMO.BLL.DTOs.DepartmentDtos;
using DEMO.BLL.DTOs.EmployeeDtos;
using DEMO.BLL.Services.Classes;
using DEMO.BLL.Services.Interfaces;
using DEMO.DAL.Models.EmployeeModel;
using DEMO.DAL.Models.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DEMO.PL.Controllers
{
    public class EmployeesController(IEmployeeServices _employeeServices, IWebHostEnvironment _environment) : Controller
    {
        public IActionResult Index()
        {

            var employees = _employeeServices.GetAllEmplyees();
            return View(employees);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreatedEmployeeDto employeeDto )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int res = _employeeServices.AddEmployee(employeeDto);
                    if (res > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee Can't Be Added");
                        return View(employeeDto);
                    }
                }

                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);

                        return View(employeeDto);
                    }
                    else
                    {
                        return View(employeeDto);
                    }
                }

            }
            else return View(employeeDto);
        }

        [HttpGet]

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var employee = _employeeServices.GetEmployeeById(id.Value);
            if (employee is null) return NotFound();

            else
            {
                return View(employee);
            }

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var employee = _employeeServices.GetEmployeeById(id.Value);

            if (employee is null) return NotFound();


            var dto = new UpdatedEmployeeDto()
            {
                Id = employee.Id,
                Address = employee.Address ,
                Age = employee.Age , 
                Email = employee.Email , 
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType) ,
                Gender = Enum.Parse<Gender>(employee.Gender),
                HiringDate = employee.HiringDate, 
                IsActive = employee.IsActive,
                Name = employee.Name , 
                PhoneNumber = employee.PhoneNumber,
                Salary  = employee.Salary
                
            };
                return View(dto);
            

        }
        //[HttpPost]
        //public IActionResult Edit([FromRoute] int id, UpdatedEmployeeDto dto)
        //{

        //    if (id !=dto.Id) return BadRequest();




        //}


    }
}
