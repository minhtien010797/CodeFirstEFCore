using System.Collections.Generic;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class StudentResourceDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Score { get; set; }
    }
    public class StudentResourceInput
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Score { get; set; }
    }
}