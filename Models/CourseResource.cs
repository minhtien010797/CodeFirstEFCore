using System.Collections.Generic;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class CourseResource
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}