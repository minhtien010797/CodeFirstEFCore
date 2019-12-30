using System.Collections.Generic;
using System.Linq;
using CodeFirstEFCore.Entities;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherManager _teacherManager;
        public TeacherService(ITeacherManager teacherManager)
        {
            _teacherManager = teacherManager;
        }
        public List<TeacherResource> getAll()
        {
            return _teacherManager.get().Select(c => new TeacherResource
            {
                Id = c.Id,
                TeacherName = c.TeacherName
            }).ToList();
        }

        public TeacherResource getById(int id)
        {
            var teacher = _teacherManager.get().FirstOrDefault(t => t.Id == id);
            return new TeacherResource
            {
                Id = teacher.Id,
                TeacherName = teacher.TeacherName
            };
        }

        public bool update(TeacherResource teacher)
        {
            _teacherManager.update(new Teacher
            {
                Id = teacher.Id,
                TeacherName = teacher.TeacherName
            });
            _teacherManager.SaveChange();
            return true;
        }
        public bool add(TeacherResource teacher)
        {
            _teacherManager.add(new Teacher
            {
                TeacherName = teacher.TeacherName
            });
            _teacherManager.SaveChange();
            return true;
        }

        public bool delete(int id)
        {
            _teacherManager.delete(id);
            _teacherManager.SaveChange();
            return true;
        }
    }
}