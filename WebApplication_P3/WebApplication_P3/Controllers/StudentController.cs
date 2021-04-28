using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_P3.Controllers
{
    [ApiController]
    [Route("[/api/students]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
            
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return new List<Student>(); 
        }

        [HttpPost]
        public Student CreateStudents([FromBody] string studentName)
        {
            return new Student()
            { 
                Name = studentName
            };
        }

        [HttpGet]
        public Student UpdateStudents([FromBody] Student student)
        {
            student.Name = "updated";
            return student; 
        }

        [HttpDelete]
        public Student DeleteStudents([FromBody]Student student)
        {
            return student;
        }
    }
}
