using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte Score { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}