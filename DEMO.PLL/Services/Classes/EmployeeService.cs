using AutoMapper;
using DEMO.BLL.DTOs.EmployeeDtos;
using DEMO.BLL.Services.Interfaces;
using DEMO.DAL.Models.EmployeeModel;
using DEMO.DAL.Repositories.IRepos;
using NHibernate.Mapping.ByCode.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.BLL.Services.Classes
{
    public class EmployeeService(IEmployeeRepository _employeeRepository , IMapper _mapper) : IEmployeeServices
    {
        public IEnumerable<EmployeeDto> GetAllEmplyees(bool witheTraking = false)
        {

            var employees = _employeeRepository.GetAll();
            var employeesDto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return employeesDto;



        }

        public EmployeeDetailsDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);
           
            return employee == null ? null : _mapper.Map<EmployeeDetailsDto>(employee); ;
        }

        public int UpdateEmployee(UpdatedEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);

            return _employeeRepository.Update(employee);
        }

        public int AddEmployee(CreatedEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            return _employeeRepository.Add(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _employeeRepository.GetById(id);

            if (employee == null) return false;

            else
            {
                employee.IsDeleted = true; 
                return _employeeRepository.Update(employee)>0 ? true : false;
            }
        }


    }
}
