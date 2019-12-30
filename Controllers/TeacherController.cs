using System.Collections.Generic;
using CodeFirstEFCore.Models;
using CodeFirstEFCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEFCore.Controllers
{
    [ApiController]
    [Route("/api/teachers/")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        public List<TeacherResource> GetAllTeachers()
        {
            var teacherList = _teacherService.getAll();
            return teacherList;
        }

        [HttpGet("{id}")]
        public ActionResult<TeacherResource> GetTeacherById(int id)
        {
            var teacher = _teacherService.getById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
        }

        [HttpPost]
        public ActionResult Post(TeacherResource teacher)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data Invalid.");
            _teacherService.add(teacher);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<TeacherResource> Put(TeacherResource teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _teacherService.update(teacher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _teacherService.delete(id);
            return Ok();
        }
    }
}