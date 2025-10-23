using DEMO.DAL.Models.Shared;

namespace DEMO.DAL.Models.DepartmentModels
{
    public class Department:BaseEntity
    {
        public int DeptId;
        public DateOnly DateOfCreation;

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }


    }
}
