using System.Linq;
using CodeFirstEFCore.Context;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public class StudentManager : IStudentManager
    {
        private readonly SchoolContext _schoolContext;
        public StudentManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public void add(Student student)
        {
            _schoolContext.Students.Add(student);
        }

        public void delete(int id)
        {
            var student = _schoolContext.Students.FirstOrDefault(s => s.Id == id);
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

        public void update(Student student)
        {
            var std = _schoolContext.Students.FirstOrDefault(c => c.Id == student.Id);
            std.FirstName = student.FirstName;
            std.LastName = student.LastName;
            std.Score = std.Score;
        }
    }
}