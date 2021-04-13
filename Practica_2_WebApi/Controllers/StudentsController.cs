using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practica_2_WebApi.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
          
        }

        [HttpGet]
        public List<Student> GetStudent()
        {
            return new List<Student>();
        }
         [HttpPost]
        public Student CreateStudent([FromBody] string studentName)
        {
            return new Student()
            {
                 NameStudent = studentName
            };
        }

         [HttpPut]
        public Student UpdateStudent([FromBody] Student estudiante)
        {
            estudiante.NameStudent = "updated";
            return estudiante;
        }

         [HttpDelete] 
        public Student DeleteStudent([FromBody] string studentName)
        {
            return new Student()
            {
                 NameStudent = studentName
            };
        }

    }
}
