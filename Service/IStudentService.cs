using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface IStudentService
    {
        List<StudentResourceDTO> getAll();
        List<StudentResourceDTO> getByClass(string className);
        StudentResourceDTO getById(int id);
        bool add(StudentResourceInput student);
        bool update(StudentResourceInput student);
        bool delete(int id);
    }
}