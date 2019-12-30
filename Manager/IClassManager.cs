using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface IClassManager
    {
        IQueryable<Class> get();
        void add(Class cls);
        void update(Class cls);
        void delete(int id);
        void SaveChange();
    }
}