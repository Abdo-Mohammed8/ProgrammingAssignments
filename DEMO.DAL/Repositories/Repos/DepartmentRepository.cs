using DEMO.DAL.Data.Contexts;
using DEMO.DAL.Models.DepartmentModels;
using DEMO.DAL.Repositories.IRepos;


namespace DEMO.DAL.Repositories.Repos

    // primary constructor
{
    public class DepartmentRepository(ApplicationDbContext _context) : GenericRepository<Department>(_context), IDepartmentRepository

    // high level model
    {





    }


}
