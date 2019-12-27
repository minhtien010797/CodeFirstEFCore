using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte Score { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual StudentFailed StudentFailed { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}