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
        public bool add(StudentResourceInput student)
        {
            _studentManager.add(new Student
            {
                Id = student.Id,
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

        public List<StudentResourceDTO> getAll()
        {
            return _studentManager.get().Select(s => new StudentResourceDTO
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Score = s.Score
            }).ToList();
        }

        public List<StudentResourceDTO> getByClass(string className)
        {
            return _studentManager.get().Where(s => s.Class.ClassName == className).Select(
                s => new StudentResourceDTO
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Score = s.Score
                }).ToList();
        }

        public StudentResourceInput getById(int id)
        {
            var student = _studentManager.get().FirstOrDefault(t => t.Id == id);
            return new StudentResourceInput
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Score = student.Score
            };
        }

        public bool update(StudentResourceInput student)
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

        StudentResourceDTO IStudentService.getById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}