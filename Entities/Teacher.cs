using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}