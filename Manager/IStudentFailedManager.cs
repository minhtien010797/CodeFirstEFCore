using System.Linq;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore.Manager
{
    public interface IStudentFailedManager
    {
        IQueryable<Student> get();
        void add(StudentFailed student);
        void delete(int id);
        void SaveChange();
    }
}