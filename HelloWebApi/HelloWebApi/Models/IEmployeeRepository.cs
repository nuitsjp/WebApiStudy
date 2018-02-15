using System.Collections.Generic;
using HelloWebApi.Controllers;

namespace HelloWebApi.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmoloyees();
    }
}