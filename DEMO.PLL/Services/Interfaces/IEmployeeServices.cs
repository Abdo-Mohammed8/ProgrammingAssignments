using DEMO.BLL.DTOs;
using DEMO.BLL.DTOs.DepartmentDtos;
using DEMO.BLL.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.BLL.Services.Interfaces
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> GetAllEmplyees(bool witheTraking = false);

        EmployeeDetailsDto? GetEmployeeById(int id);

        int AddEmployee(CreatedEmployeeDto employeeDto);
        bool DeleteEmployee(int id);

        int UpdateEmployee(UpdatedEmployeeDto employeeDto);
    }
}
