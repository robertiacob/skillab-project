
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillabApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee{
                Id = 1,
                Fullname = "Iacob Robert",
                BirthDate = DateTime.Now.AddYears(-29),
                Job = "Software Engineer",
                FavouritePictureLink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            },
            new Employee{
                Id = 2,
                Fullname = "Stefan Alexandru",
                BirthDate = DateTime.Now.AddYears(-27),
                Job = "Software Developer",
                FavouritePictureLink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            },
            new Employee{
                Id = 3,
                Fullname = "Radulescu Andrei",
                BirthDate = DateTime.Now.AddYears(-40),
                Job = "Programmer",
                FavouritePictureLink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            }
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Employee> GetAll(){
            
            return Employees;
        }

        [HttpGet]
        public Employee GetById(int Id)
        {

            return Employees.FirstOrDefault(e => e.Id == Id);
        }
    }
}
