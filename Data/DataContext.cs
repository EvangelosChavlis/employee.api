using employee.api.Models;
using Microsoft.EntityFrameworkCore;

namespace employee.api.Data;

public class DataContext : DbContext 
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}