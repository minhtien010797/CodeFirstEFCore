using System.Collections.Generic;
using CodeFirstEFCore.Manager;
using CodeFirstEFCore.Models;
using CodeFirstEFCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEFCore.Controllers
{
    [ApiController]
    [Route("/api/studentfailed")]
    public class StudentFailedController : ControllerBase
    {
        private readonly IStudentFailedService _studentFailedService;
        public StudentFailedController(IStudentFailedService studentFailedService)
        {
            _studentFailedService = studentFailedService;
        }

        [HttpGet]
        public List<StudentFailedResource> GetStudentFailed()
        {
            var studentList = _studentFailedService.updateStudentFailed();
            return studentList;
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _studentFailedService.delete(id);
            return Ok();
        }
    }
}