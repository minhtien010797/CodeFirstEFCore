using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class TeacherResource
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}