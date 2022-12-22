using employee.api.Models;

namespace employee.api.Services;

public interface IEmployeesService
{
    Task<List<Employee>> GetEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(Guid id);
    Task<string> CreateEmployeeAsync(EmployeeDto dto);
    Task<string> UpdateEmployeeAsync(Guid id, EmployeeDto dto);
    Task<string> DeleteEmployeeAsync(Guid id);             
}