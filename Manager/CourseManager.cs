using System.Linq;
using CodeFirstEFCore.Context;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public class CourseManager : ICourseManager
    {
        private readonly SchoolContext _schoolContext;

        public CourseManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public void add(Course course)
        {
           _schoolContext.Courses.Add(course);
        }

        public void delete(int id)
        {
            var course = _schoolContext.Courses.FirstOrDefault(c => c.Id == id);
            _schoolContext.Courses.Remove(course);
        }

        public IQueryable<Course> get()
        {
            return _schoolContext.Courses;
        }

        public void SaveChange()
        {
            _schoolContext.SaveChanges();
        }

        public void update(Course course)
        {
            var c = _schoolContext.Courses.FirstOrDefault(c => c.Id == course.Id);
            c.CourseName = course.CourseName;
        }
    }
}