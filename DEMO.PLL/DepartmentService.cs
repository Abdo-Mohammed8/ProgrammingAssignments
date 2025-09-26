using DEMO.DAL.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.BLL
{
    public class DepartmentService
    {
        public DepartmentService() 
        {
            ApplicationDbContext context = new ApplicationDbContext();
        }

        public void UpdateDepartment(int id)
        {

        }
    }
}
