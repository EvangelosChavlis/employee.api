using employee.api.Data;
using employee.api.Models;
using Microsoft.EntityFrameworkCore;

namespace employee.api.Services;

public class EmployeesService : IEmployeesService
{   
    private readonly DataContext _context;
    
    public EmployeesService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var employees = await _context.Employees
        .OrderBy(x => x.LastName)
        .OrderBy(x => x.FirstName)
        .ToListAsync();

        return employees;
    
    }

    public async Task<Employee> GetEmployeeByIdAsync(string id)
    {
        var employee = await _context.Employees
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();

        if (employee == null)
            throw new Exception("Employee was not found");

        return employee;
    }

    public async Task<string> CreateEmployeeAsync(EmployeeDto dto)
    {
        var employee = new Employee()
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Address = dto.Address,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber
        };

        await _context.AddAsync(employee);
        var res =  await _context.SaveChangesAsync() > 0;

        return res ? "Employee successfully created" : "Error in employee creation";
    } 

    public async Task<string> UpdateEmployeeAsync(string id, EmployeeDto dto)
    {
        var employee = await _context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();

        if (employee == null)
            throw new Exception("Employee was not found");

        employee.FirstName = dto.FirstName ?? employee.FirstName;
        employee.LastName = dto.LastName ?? employee.LastName;
        employee.Address = dto.Address ?? employee.Address;
        employee.Email = dto.Email ?? employee.Email;
        employee.PhoneNumber = dto.PhoneNumber ?? employee.PhoneNumber;

        _context.Employees.Update(employee);
        var res =  await _context.SaveChangesAsync() > 0;

        return res ? "Employee successfully updated" : "Error in employee update";
    }


    public async Task<string> DeleteEmployeeAsync(string id)
    {
        var employee = await _context.Employees
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();

        if (employee == null)
            throw new Exception("Employee was not found");

        _context.Employees.Remove(employee);
        var res =  await _context.SaveChangesAsync() > 0;

        return res ? "Employee successfully deleted" : "Error in employee deletion";
    } 
}
