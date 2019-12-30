using System.Collections.Generic;
using System.Linq;
using CodeFirstEFCore.Entities;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseManager _courseManager;
        public CourseService(ICourseManager courseManager)
        {
            _courseManager = courseManager;
        }
        public bool add(CourseResource course)
        {
            _courseManager.add(new Course
            {
                CourseName = course.CourseName
            });
            _courseManager.SaveChange();
            return true;
        }

        public bool delete(int id)
        {
            _courseManager.delete(id);
            _courseManager.SaveChange();
            return true;
        }

        public List<CourseResource> getAll()
        {
            return _courseManager.get().Select(c => new CourseResource
            {
                Id = c.Id,
                CourseName = c.CourseName
            }).ToList();
        }

        public CourseResource getById(int id)
        {
            var course = _courseManager.get().FirstOrDefault(c => c.Id == id);
            return new CourseResource
            {
                Id = course.Id,
                CourseName = course.CourseName
            };
        }

        public bool update(CourseResource course)
        {
            _courseManager.update(new Course
            {
                Id = course.Id,
                CourseName = course.CourseName
            });
            _courseManager.SaveChange();
            return true;
        }
    }
}