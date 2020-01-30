using System.Collections.Generic;
using CodeFirstEFCore.Models;
using CodeFirstEFCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEFCore.Controllers
{
    [ApiController]
    [Route("/api/students/")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<StudentResource> GetAllStudents()
        {
            var studentList = _studentService.getAll();
            return studentList;
        }

        [HttpGet("class/{className}")]
        public List<StudentResource> GetAllByClassName(string className)
        {
            var studentList = _studentService.getByClass(className);
            return studentList;
        }

        [HttpGet("{id}")]
        public ActionResult<StudentResource> GetStudentById(int id)
        {
            var std = _studentService.getById(id);
            if (std == null)
            {
                return NotFound();
            }
            return std;
        }

        [HttpPost]
        public ActionResult Post(StudentResource student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data Invalid.");
            _studentService.add(student);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<StudentResource> Put(StudentResource student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _studentService.update(student);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {    
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _studentService.delete(id);
            return Ok();
        }

    }
}