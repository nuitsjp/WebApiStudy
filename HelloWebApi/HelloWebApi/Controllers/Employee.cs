using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebApi.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}