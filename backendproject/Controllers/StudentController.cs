using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Age = 18, Id = 24366,
                First_Name = "Valentino", Last_Name = "Roux" });
            students.Add(new Student()
            {
                Age = 20,
                Id = 24356,
                First_Name = "Gaetan",
                Last_Name = "Jalef"
            });
            return students;
        }

        [HttpGet]

        public IEnumerable<Student> GetStudents_List()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]

        public ActionResult<Student> Get_Student_byID(int id)
        {
            var student = GetStudents().Find(x => x.Id == id);
            if(student != null)
            {
                return student;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
