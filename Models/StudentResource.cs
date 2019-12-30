using System.Collections.Generic;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class StudentResource
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte Score { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public StudentFailed StudentFailed { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}