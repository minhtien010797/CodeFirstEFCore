using System.Collections.Generic;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Models
{
    public class StudentResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Score { get; set; }
    }
    // public class StudentInput
    // {
    //     public string FirstName { get; set; }
    //     public string LastName { get; set; }
    //     public string Score { get; set; }
    // }
}