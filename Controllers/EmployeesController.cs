using employee.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace employee.api.Controllers;

[Route("api/employees")]
public class EmployeesController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetEmployees() 
        => Ok(await  _employeesService.GetEmployeesAsync());
    

    [Route("{id}")]
    [HttpGet]
    public async Task<IActionResult> GetEmployeeById(string id) 
        => Ok(await  _employeesService.GetEmployeeByIdAsync(id));
    

    [HttpPost]
    public async Task<IActionResult> CreateEmployee([FromBody] EmployeeDto dto)
        => Ok(await  _employeesService.CreateEmployeeAsync(dto));


    [Route("{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateEmployee(string id, [FromBody] EmployeeDto dto)
        => Ok(await  _employeesService.UpdateEmployeeAsync(id, dto));


    [Route("{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteEmployee(string id)
        => Ok(await  _employeesService.DeleteEmployeeAsync(id));
}