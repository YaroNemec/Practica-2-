using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practica_2_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public List<Student> GetStudent()
        {
            return new List<Student>();
        }

    }
}
