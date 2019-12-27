namespace CodeFirstEFCore.Entities
{
    public class StudentFailed
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}