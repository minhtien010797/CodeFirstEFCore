using System.Collections.Generic;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class ClassResource
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}