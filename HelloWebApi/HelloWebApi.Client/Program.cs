using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWebApi.Service.Api;

namespace HelloWebApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeApi = new EmployeesApi("http://localhost:9000");
            foreach (var employee in employeeApi.EmployeesGet())
            {
                Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} BirthDay:{employee.BirthDay}");
            }
            Console.ReadLine();
        }
    }
}
