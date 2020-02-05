using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFCore.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Score { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual StudentFailed StudentFailed { get; set; }
        public int? ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}