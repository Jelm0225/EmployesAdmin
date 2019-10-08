using EmployesAdmin.Business;
using EmployesAdmin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployesAdmin.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IEmpoye employeService;

        public ValuesController(IEmpoye employeService)
        {
            this.employeService = employeService;
        }


        // GET api/values
        public IEnumerable<EmployesAnualSalary> Get()
        {
            return employeService.GetEmployes();
        }

        // GET api/values/5
        public IEnumerable<EmployesAnualSalary> Get(string employeName)
        {
            return employeService.GetEmployes(employeName);
        }

    }
}
