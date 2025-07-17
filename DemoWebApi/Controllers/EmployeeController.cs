using Microsoft.AspNetCore.Mvc;
using DemoWebApi.Data;
using DemoWebApi.Models;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAllEmployees), new { id = emp.EmployeeId }, emp);
        }
    }
}
