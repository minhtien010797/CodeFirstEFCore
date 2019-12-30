using System.Linq;
using CodeFirstEFCore.Context;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public class TeacherManager : ITeacherManager
    {
        private readonly SchoolContext _schoolContext;
        public TeacherManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public IQueryable<Teacher> get()
        {
            return _schoolContext.Teachers;
        }
        public void add(Teacher teacher)
        {
            _schoolContext.Teachers.Add(teacher);
        }
         public void update(Teacher teacher)
        {
            var teach = _schoolContext.Teachers.FirstOrDefault(c => c.Id == teacher.Id);
            teach.TeacherName = teacher.TeacherName;
        }
        public void delete(int id)
        {
            var teacher = _schoolContext.Teachers.FirstOrDefault(t => t.Id == id);
            _schoolContext.Teachers.Remove(teacher);
        }
        public void SaveChange()
        {
            _schoolContext.SaveChanges();
        }

    }
}