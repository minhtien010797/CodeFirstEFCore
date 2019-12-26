using System.Collections.Generic;

namespace CodeFirstEFCore.Entities
{
    public class Classes
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}