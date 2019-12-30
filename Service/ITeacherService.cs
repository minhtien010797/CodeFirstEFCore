using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface ITeacherService
    {
        List<TeacherResource> getAll();
        TeacherResource getById(int id);
        bool add(TeacherResource teacher);
        bool update(TeacherResource teacher);
        bool delete(int id);
    }
}