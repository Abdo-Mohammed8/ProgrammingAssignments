using DEMO.DAL.Models.EmployeeModel;
using DEMO.DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAL.Data.Configurations
{
    public class EmployeeConfigrations : BaseEntityConfigrations<Employee> ,IEntityTypeConfiguration<Employee>
    {
        public new void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).HasColumnType("varchar(50)");
            builder.Property(e => e.Email).HasColumnType("varchar(150)");
            builder.Property(e => e.Salary).HasColumnType("decimal(10,20)");

            builder.Property(e => e.Gender).HasConversion((eG)=>eG.ToString(),(g)=>(Gender)Enum.Parse(typeof(Gender),g));

            builder.Property(e => e.EmployeeType).HasConversion((eT)=>eT.ToString(),(t)=>(EmployeeType)Enum.Parse(typeof(EmployeeType),t));
            
            base.Configure(builder);
            
        }
    }
}
