using System.Linq;
using CodeFirstEFCore.Context;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public class ClassManager : IClassManager
    {
        private readonly SchoolContext _schoolContext;
        public ClassManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public void add(Class cls)
        {
            _schoolContext.Classes.Add(cls);
        }

        public void delete(int id)
        {
            var cls = _schoolContext.Classes.FirstOrDefault(c => c.Id == id);
            _schoolContext.Classes.Remove(cls);
        }

        public IQueryable<Class> get()
        {
            return _schoolContext.Classes;
        }

        public void SaveChange()
        {
            _schoolContext.SaveChanges();
        }

        public void update(Class cls)
        {
            var c = _schoolContext.Classes.FirstOrDefault(c => c.Id == cls.Id);
            c.ClassName = cls.ClassName;
        }
    }
}