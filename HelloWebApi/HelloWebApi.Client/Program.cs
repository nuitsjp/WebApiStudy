using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace HelloWebApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new HelloWebApiClient(new Uri("http://localhost:9000"), new AnonymousCredentials()))
            //{
            //    foreach (var employee in client.GetEmployees())
            //    {
            //        Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} BirthDay:{employee.BirthDay}");
            //    }
            //    Console.ReadLine();
            //}
        }

        private class AnonymousCredentials : ServiceClientCredentials
        {
        }
    }
}
