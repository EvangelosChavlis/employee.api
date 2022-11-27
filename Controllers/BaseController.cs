using employee.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace employee.api.Controllers;

[ApiController]
public class BaseController : ControllerBase
{
    private IEmployeesService EmployeesService;

    protected IEmployeesService _employeesService => EmployeesService ??= HttpContext.RequestServices.GetService<IEmployeesService>();
}