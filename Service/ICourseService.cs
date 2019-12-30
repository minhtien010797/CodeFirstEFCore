using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface ICourseService
    {
        List<CourseResource> getAll();
        CourseResource getById(int id);
        bool add(CourseResource course);
        bool update(CourseResource course);
        bool delete(int id);
    }
}