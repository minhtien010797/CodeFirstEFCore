using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}