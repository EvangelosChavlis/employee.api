using employee.api.Models;

namespace employee.api.Services;

public interface IEmployeesService
{
    Task<List<Employee>> GetEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(string id);
    Task<string> CreateEmployeeAsync(EmployeeDto dto);
    Task<string> UpdateEmployeeAsync(string id, EmployeeDto dto);
    Task<string> DeleteEmployeeAsync(string id);             
}