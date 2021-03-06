﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWebApi.Models;
using Swashbuckle.Swagger.Annotations;

namespace HelloWebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        protected EmployeesController()
        {
        }

        // GET api/<controller>
        [Intercept]
        public virtual IEnumerable<Employee> Get()
        {
            var isAuthenticated = User.Identity.IsAuthenticated;
            var user = User.Identity.Name;
            return _employeeRepository.GetEmoloyees();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}