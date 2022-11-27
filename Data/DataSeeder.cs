using employee.api.Models;

namespace employee.api.Data;

public class DataSeeder
{
    public static void Seed(WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetService<DataContext>();

        if(!context.Employees.Any())
        {
            var employees = new List<Employee>()
            {
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Evangelos",
                    LastName = "Chavlis",
                    Address = "somewhere 123, City",
                    Email = "vagelis@email.com",
                    PhoneNumber = "123456" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Gerasimos",
                    LastName = "Tzivras",
                    Address = "somewhere 1234, City",
                    Email = "jerry@email.com",
                    PhoneNumber = "654321" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Panagiotis",
                    LastName = "Georgiou",
                    Address = "somewhere 12, City",
                    Email = "panos@email.com",
                    PhoneNumber = "65432112" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Thanasis",
                    LastName = "Georgiou",
                    Address = "somewhere 12, City",
                    Email = "thanos@email.com",
                    PhoneNumber = "45654654" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Dimitris",
                    LastName = "Georgiou",
                    Address = "somewhere 12, City",
                    Email = "mitsos@email.com",
                    PhoneNumber = "821586" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Dimitris",
                    LastName = "Athanasiou",
                    Address = "somewhere 12, City",
                    Email = "mitsos.ath@email.com",
                    PhoneNumber = "654564654" 
                },
                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Kostas",
                    LastName = "Agapiou",
                    Address = "somewhere 178, City",
                    Email = "kostas@email.com",
                    PhoneNumber = "654564654" 
                },
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}