using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface IStudentService
    {
        List<StudentResource> getAll();
        List<StudentResource> getByClass(string className);
        StudentResource getById(int id);
        bool add(StudentResource student);
        bool update(StudentResource student);
        bool delete(int id);
    }
}