using System.Collections.Generic;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public interface IStudentFailedService
    {
        List<StudentFailedResource> updateStudentFailed();
        bool delete(int id);
    }
}