using DEMO.DAL.Data.Contexts;
using DEMO.DAL.Models.EmployeeModel;
using DEMO.DAL.Repositories.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAL.Repositories.Repos
{
    public class EmployeeRepository(ApplicationDbContext _context ): GenericRepository<Employee>(_context), IEmployeeRepository
    {


    }
}
