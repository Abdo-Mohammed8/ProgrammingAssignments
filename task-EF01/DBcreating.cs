using Assignment01;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_EF01
{
    //  DbContext 
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CORCM0G\\SQL2022MY;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Instructor Mapping (Fluent API)
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Bouns).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Salary).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Adress).HasMaxLength(200);
                entity.Property(e => e.HourRate).HasColumnType("decimal(5,2)");
            });

            // Department Mapping (Fluent API)
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
            });

            // Stud_Course Mapping (Fluent API)
            modelBuilder.Entity<Stud_Course>(entity =>
            {
                entity.ToTable("Stud_Course");
                entity.HasKey(e => new { e.stud_ID, e.Course_ID });
                entity.Property(e => e.Grade).HasColumnType("decimal(5,2)");
            });

            // Course_Inst Mapping (Fluent API)
            modelBuilder.Entity<Course_Inst>(entity =>
            {
                entity.ToTable("Course_Inst");
                entity.HasKey(e => new { e.inst_ID, e.Course_ID });
                entity.Property(e => e.evaluate).HasMaxLength(200);
            });
        }
    }
}
