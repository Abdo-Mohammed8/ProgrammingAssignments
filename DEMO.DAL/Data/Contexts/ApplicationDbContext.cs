using DEMO.DAL.Data.Configurations;
using DEMO.DAL.Models.ApplicationUser;
using DEMO.DAL.Models.DepartmentModels;
using DEMO.DAL.Models.EmployeeModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace DEMO.DAL.Data.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Models.DepartmentModels.Department> Departments { get; set; }

        public DbSet<Models.EmployeeModel.Employee> Employees { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //public DbSet<IdentityRole> IdentityRole { get; set; }

    }
}
