using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface IStudentManager
    {
        IQueryable<Student> get();
        void add(Student student);
        void update(Student student);
        void delete(int id);
        void SaveChange();
    }
}