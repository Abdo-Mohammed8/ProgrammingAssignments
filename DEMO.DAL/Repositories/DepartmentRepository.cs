

using DEMO.DAL.Data.Contexts;

namespace DEMO.DAL.Repositories

    // primary constructor
{
    internal class DepartmentRepository(ApplicationDbContext context) // high level model
    {


        // CRUD
        // Get Department By Id


        public Department? GetBtId (int id )
        {
            var department = context.Departments.Find(id);

            return department;
        }
        // Get All Departments
        // Add Department
        // Update Department
        // Delete Department 


        
    }

   
}
