using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface ITeacherManager
    {
        IQueryable<Teacher> get();
        void add(Teacher course);
        void update(Teacher course);
        void delete(int id);
        void SaveChange();
    }
}