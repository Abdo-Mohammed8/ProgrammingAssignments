using DEMO.DAL.Data.Contexts;


namespace DEMO.DAL.Repositories.Repos

    // primary constructor
{
    public class DepartmentRepository(ApplicationDbContext _context) : IDepartmentRepository

    // high level model
    {



        // CRUD
        // Get Department By Id
        public Department? GetById(int id)
        {
            var department = _context.Departments.Find(id);

            return department;
        }
        // Get All Departments
        public IEnumerable<Department> GetAll(bool withTracking = false)
        {
            if (withTracking) return _context.Departments.ToList();
            else return _context.Departments.AsNoTracking().ToList();
        }
        // Add Department
        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }


        // Update Department
        public int Update(Department department)
        {

            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
        // Delete Department 

        public int Remove(Department department)
        {

            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }


    }


}
