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
        public List<StudentResourceDTO> GetAllStudents()
        {
            var studentList = _studentService.getAll();
            return studentList;
        }

        [HttpGet("class/{className}")]
        public List<StudentResourceDTO> GetAllByClassName(string className)
        {
            var studentList = _studentService.getByClass(className);
            return studentList;
        }

        [HttpGet("{id}")]
        public ActionResult<StudentResourceDTO> GetStudentById(int id)
        {
            var std = _studentService.getById(id);
            if (std == null)
            {
                return NotFound();
            }
            return std;
        }

        [HttpPost]
        public ActionResult Post([FromBody]StudentResourceInput student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data Invalid.");
            _studentService.add(student);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<StudentResourceInput> Put([FromBody]StudentResourceInput student)
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