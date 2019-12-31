using System.Collections.Generic;
using System.Linq;
using CodeFirstEFCore.Entities;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore.Service
{
    public class StudentFailedService : IStudentFailedService
    {
        private readonly IStudentFailedManager _studentFailedManager;
        public StudentFailedService(IStudentFailedManager studentFailedManager)
        {
            _studentFailedManager = studentFailedManager;
        }

        public bool delete(int id)
        {
            _studentFailedManager.delete(id);
            return true;
        }

        public List<StudentFailedResource> updateStudentFailed()
        {   
            var listStudentFailed = _studentFailedManager.get().Include(s => s.StudentFailed)
                                                    .Where(s => s.Score < 5)
                                                    .Select(s => new StudentFailedResource
                                                    {
                                                        StudentId = s.Id
                                                    }).ToList();
            foreach (var item in listStudentFailed)
            {
                _studentFailedManager.add(new StudentFailed
                {
                    StudentId = item.StudentId
                });
                _studentFailedManager.SaveChange();
            };
            return listStudentFailed;
        }

    }
}