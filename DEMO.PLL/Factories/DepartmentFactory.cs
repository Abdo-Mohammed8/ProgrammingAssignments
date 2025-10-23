using DEMO.BLL.DTOs.DepartmentDtos;
using DEMO.DAL.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.BLL.Factories
{
    static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department department)
        {
            return new DepartmentDto
            {
                DeptId = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = DateOnly.FromDateTime(department.CreatedOn),
            };
        }
        public static DepartmentDetallsDto ToDepartmentDetallsDto(this Department dept)
        {
            return new DepartmentDetallsDto()
            {
                DeptId = dept.Id,
                Name = dept.Name,
                Code = dept.Code,
                Description = dept.Description,
                DateOfCreation = DateOnly.FromDateTime(dept.CreatedOn),
                IsDeleted = dept.IsDeleted,
                LastModifiedBy = dept.LastModifiedBy,
                LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn),
            };
        }


        public static Department ToEntity(this CreatedDepartmentDto dto)
        {

            return new Department()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedOn = dto.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }

        public static Department ToEntity(this UpdatedDepartmentDto dto)
        {

            return new Department()
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedOn = dto.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }

    }
}
