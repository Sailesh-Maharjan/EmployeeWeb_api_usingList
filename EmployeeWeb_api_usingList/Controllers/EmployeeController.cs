using EmployeeWeb_api_usingList.Models;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWeb_api_usingList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        

        public static readonly List<Employee> Employees = new List<Employee>();
        static EmployeeController()
        {
            Employees.Add(new Employee() { EmployeeId = 1, Name = "sailesh", Address = "Harisiddhi", Salary = 123 });
            Employees.Add(new Employee() { EmployeeId = 2, Name = "Ashim", Address = "Thaiba", Salary = 321 });
            Employees.Add(new Employee() { EmployeeId = 3, Name = "Sudan", Address = "Hattiban", Salary = 234 });
            Employees.Add(new Employee() { EmployeeId = 4, Name = "Abesh", Address = "kharibot", Salary = 432 });
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return Employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var emp = Employees.FirstOrDefault(item => item.EmployeeId == id);   //LINQ operation
            return emp;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            Employees.Add(emp);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            var emp = Employees.FirstOrDefault(item => item.EmployeeId == id);   //LINQ operation
            emp.Name= employee.Name;
            emp.Salary= employee.Salary;
            emp.Address= employee.Address;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var emp = Employees.FirstOrDefault(item => item.EmployeeId == id);   //LINQ operation
            Employees.Remove(emp);
        }
    }
}
