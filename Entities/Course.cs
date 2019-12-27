using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}