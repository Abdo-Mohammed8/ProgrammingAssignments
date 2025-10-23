

using DEMO.DAL.Models.DepartmentModels;

namespace DEMO.DAL.Data.Configurations
{
    internal class DepartmentConfiguration : BaseEntityConfigrations<Department> , IEntityTypeConfiguration<Department>
    {
       public new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10,10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.Code).HasColumnType("varchar(20)");
            builder.Property(d => d.Description).HasColumnType("varchar(200)");
  
            base.Configure(builder);

        }
    }
}
