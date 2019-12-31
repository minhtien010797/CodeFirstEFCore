using System.Collections.Generic;
using System.Linq;
using CodeFirstEFCore.Entities;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentManager _studentManager;
        public StudentService(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        public bool add(StudentResource student)
        {
            _studentManager.add(new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Score = student.Score
            });
            _studentManager.SaveChange();
            return true;
        }

        public bool delete(int id)
        {
            _studentManager.delete(id);
            _studentManager.SaveChange();
            return true;
        }

        public List<StudentResource> getAll()
        {
            return _studentManager.get().Select(s => new StudentResource
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Score = s.Score
            }).ToList();
        }

        public List<StudentResource> getByClass(string className)
        {
            return _studentManager.get().Where(s => s.Class.ClassName == className).Select(
                s => new StudentResource
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Score = s.Score
                }).ToList();
        }

        public StudentResource getById(int id)
        {
            var student = _studentManager.get().FirstOrDefault(t => t.Id == id);
            return new StudentResource
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Score = student.Score
            };
        }

        public bool update(StudentResource student)
        {
            _studentManager.update(new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Score = student.Score
            });
            _studentManager.SaveChange();
            return true;
        }
    }
}