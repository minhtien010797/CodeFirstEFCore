using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public Class Classes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}