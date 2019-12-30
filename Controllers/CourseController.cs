using System.Collections.Generic;
using CodeFirstEFCore.Models;
using CodeFirstEFCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEFCore.Controllers
{
    [ApiController]
    [Route("/api/courses/")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public List<CourseResource> GetAllCourses()
        {
            var courseList = _courseService.getAll();
            return courseList;
        }

        [HttpGet("{id}")]
        public ActionResult<CourseResource> GetStudentById(int id)
        {
            var course = _courseService.getById(id);
            if (course == null)
            {
                return NotFound();
            }
            return course;
        }

        [HttpPost]
        public ActionResult Post(CourseResource course)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data Invalid.");
            _courseService.add(course);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<CourseResource> Put(CourseResource course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _courseService.update(course);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _courseService.delete(id);
            return Ok();
        }
    }
}