using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Assignment01
{
    //Convention Mapping
    public class Student
    {
        public int ID { get; set; }       
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }

    //  Data Annotations 
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

        public int Top_ID { get; set; }
    }

    [Table("Topic")]
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }

    // Fluent API 
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }

    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }
    }

    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }


}
