using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface IClassService
    {
        List<ClassResource> getAll();
        ClassResource getById(int id);
        bool add(ClassResource cls);
        bool update(ClassResource cls);
        bool delete(int id);
    }
}