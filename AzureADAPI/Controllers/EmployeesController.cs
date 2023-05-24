using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureADAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sarathlal Saseendran", Company = "Orion Business Innovations", City = "Kochi" },
                new Employee { Id = 2, Name = "Anil Soman", Company = "Cognizant", City = "Bangalare" }
            };
            return employees;
        }
    }
}
