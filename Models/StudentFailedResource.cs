using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class StudentFailedResource
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Student Student { get; set; }
    }
}