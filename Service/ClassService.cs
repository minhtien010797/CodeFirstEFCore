using System.Collections.Generic;
using System.Linq;
using CodeFirstEFCore.Entities;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;

namespace CodeFirstEFCore.Service
{
    public class ClassService : IClassService
    {
        private readonly IClassManager _classManager;
        public ClassService(IClassManager classManager)
        {
            _classManager = classManager;
        }
        public bool add(ClassResource cls)
        {
            _classManager.add(new Class
            {
                ClassName = cls.ClassName
            });
            _classManager.SaveChange();
            return true;
        }

        public bool delete(int id)
        {
            _classManager.delete(id);
            _classManager.SaveChange();
            return true;
        }

        public List<ClassResource> getAll()
        {
            return _classManager.get().Select(c => new ClassResource
            {
                Id = c.Id,
                ClassName = c.ClassName
            }).ToList();
        }

        public ClassResource getById(int id)
        {
            var cls = _classManager.get().FirstOrDefault(c => c.Id == id);
            return new ClassResource
            {
                Id = cls.Id,
                ClassName = cls.ClassName
            };
        }

        public bool update(ClassResource cls)
        {
            _classManager.update(new Class
            {
                Id = cls.Id,
                ClassName = cls.ClassName
            });
            _classManager.SaveChange();
            return true;
        }
    }
}