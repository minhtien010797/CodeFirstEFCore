using System.Linq;
using CodeFirstEFCore.Context;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public class StudentFailedManager : IStudentFailedManager
    {
        private readonly SchoolContext _schoolContext;
        public StudentFailedManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public void add(StudentFailed student)
        {
            _schoolContext.StudentFaileds.Add(student);
        }

        public void delete(int id)
        {
             var student = _schoolContext.StudentFaileds.FirstOrDefault(s => s.StudentId == id);
            _schoolContext.Remove(student);
        }

        public IQueryable<Student> get()
        {
            return _schoolContext.Students;
        }

        public void SaveChange()
        {
            _schoolContext.SaveChanges();
        }
    }
}