using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface ITeacherManager
    {
        IQueryable<Teacher> get();
        void add(Teacher teacher);
        void update(Teacher teacher);
        void delete(int id);
        void SaveChange();
    }
}