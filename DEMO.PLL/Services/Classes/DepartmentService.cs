using DEMO.BLL.DTOs.DepartmentDtos;
using DEMO.BLL.Factories;
using DEMO.BLL.Services.Interfaces;
using DEMO.DAL.Models;
using DEMO.DAL.Repositories;
using DEMO.DAL.Repositories.IRepos;

namespace DEMO.BLL.Services.Classes
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        // Get All Department

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var depts = _departmentRepository.GetAll();
            var departmentsToReturn = depts.Select(d => d.ToDepartmentDto());
            return departmentsToReturn;
        }
        public DepartmentDetallsDto? GetById(int id)
        {

            var dept = _departmentRepository.GetById(id);

            //if (depts is null) return null;
            //else
            //{
            //    var departmentsToReturn =  new DepartmentDetallsDto()
            //    {
            //        DeptId = dept.Id,
            //        Name = dept.Name,
            //        Code = dept.Code,
            //        Description = dept.Description,
            //        DateOfCreation = DateOnly.FromDateTime(dept.CreatedOn),
            //        IsDeleted = dept.IsDeleted,
            //        LastModifiedBy = dept.LastModifiedBy,
            //        LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn),
            //    };
            //    return departmentsToReturn;
            //}

            return dept is null ? null : dept.ToDepartmentDetallsDto();


        }

        public int AddDepartment(CreatedDepartmentDto departmentDto)
        {
            var entity = departmentDto.ToEntity();
            return _departmentRepository.Add(entity);
        }

        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
        {
            var entity = departmentDto.ToEntity();
            return _departmentRepository.Update(entity);
        }

        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null) return false;
            else
            {
                var res = _departmentRepository.Remove(department);
                //if (res > 0) return true;
                //else return false;

                return res > 0 ? true : false;
            }
        }
    }


}
