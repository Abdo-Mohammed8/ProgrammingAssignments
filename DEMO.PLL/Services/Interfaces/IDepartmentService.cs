using DEMO.BLL.DTOs.DepartmentDtos;

namespace DEMO.BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        int AddDepartment(CreatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetallsDto? GetById(int id);
        int UpdateDepartment(UpdatedDepartmentDto departmentDto);
    }
}