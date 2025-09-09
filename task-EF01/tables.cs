using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Assignment02
{

    public class Student
    {
        public int ID { get; set; }  // PK
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        // FK
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        // Many-to-Many with Course
        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }


    [Table("Course")]
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public int Duration { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        // FK
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

        // Many-to-Many
        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }

    [Table("Topic")]
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        // One-to-Many
        public ICollection<Course> Courses { get; set; }
    }


    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }

        // FK
        public int Dept_ID { get; set; }
        public Department Department { get; set; }

        // Many-to-Many
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public int Ins_ID { get; set; } // Manager
        public Instructor Manager { get; set; }

        public DateTime HiringDate { get; set; }

        // One-to-Many
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }

    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public Student Student { get; set; }

        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public decimal Grade { get; set; }
    }

    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string evaluate { get; set; }
    }


}
