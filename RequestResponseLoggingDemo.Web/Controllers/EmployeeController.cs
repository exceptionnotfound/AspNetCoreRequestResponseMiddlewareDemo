using Microsoft.AspNetCore.Mvc;
using RequestResponseLoggingDemo.Web.Models;
using System;

namespace RequestResponseLoggingDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Employee> GetByID(int id)
        {
            var employee = new Employee()
            {
                ID = id,
                FirstName = "firstName",
                LastName = "lastName",
                DateOfBirth = DateTime.Now.AddYears(-31)
            };

            return Ok(employee);
        }
    }
}