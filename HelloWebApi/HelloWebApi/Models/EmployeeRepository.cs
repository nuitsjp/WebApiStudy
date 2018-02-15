using System;
using System.Collections.Generic;
using HelloWebApi.Controllers;

namespace HelloWebApi.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmoloyees()
        {
            return new List<Employee>
            {
                new Employee{Id = 1, Name = "山田 太郎", BirthDay = DateTime.Parse("1970/01/01")},
                new Employee{Id = 2, Name = "佐藤 花子", BirthDay = DateTime.Parse("2000/10/11")}
            };
        }
    }
}