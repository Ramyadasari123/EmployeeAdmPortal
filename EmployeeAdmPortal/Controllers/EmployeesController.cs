using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeAdmPortal.Data;

using EmployeeAdmPortal.Model;
using EmployeeAdmPortal.Model.Entities;
namespace EmployeeAdmPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        { 
            this.dbContext = dbContext;

        }    

        //localhost:xxxx/api/employees/GetEmployeeDetails
        [HttpGet]
       
        public IActionResult GetAllEmployee()
        {
            var employees = dbContext.Employees.ToList();
            return Ok(employees);
        }
        [HttpGet]
        [Route("{id:guid}")]   
        public IActionResult GetEmployeeDetails(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = addEmployeeDto.FirstName,
                LastName = addEmployeeDto.LastName,
                Email = addEmployeeDto.Email,
                PhoneNumber = addEmployeeDto.PhoneNumber,
                Salary = addEmployeeDto.Salary
            };
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();
            return Ok(employeeEntity);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var existingEmployee = dbContext.Employees.Find(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            existingEmployee.FirstName = updateEmployeeDto.FirstName;
            existingEmployee.LastName = updateEmployeeDto.LastName;
            existingEmployee.Email = updateEmployeeDto.Email;
            existingEmployee.PhoneNumber = updateEmployeeDto.PhoneNumber;
            existingEmployee.Salary = updateEmployeeDto.Salary;
            dbContext.SaveChanges();
            return Ok(existingEmployee);
        }
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee is null)
            {
                return NotFound();
            }

            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok();
        }

    }
}
