using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface ICourseManager
    {
        IQueryable<Course> get();
        void add(Course course);
        void update(Course course);
        void delete(int id);
        void SaveChange();
    }
}