using System.Collections.Generic;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;
using CodeFirstEFCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEFCore.Controllers
{
    [ApiController]
    [Route("/api/classes/")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public List<ClassResource> GetAllClasses()
        {
            var classList = _classService.getAll();
            return classList;
        }

        [HttpGet("{id}")]
        public ActionResult<ClassResource> GetClassById(int id)
        {
            var cls = _classService.getById(id);
            if (cls == null)
            {
                return NotFound();
            }
            return cls;
        }

        [HttpPost]
        public ActionResult Post(ClassResource cls)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data Invalid.");
            _classService.add(cls);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<ClassResource> Put(ClassResource cls)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _classService.update(cls);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _classService.delete(id);
            return Ok();
        }
    }
}