using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decloud_CRUD.Interface;
using Decloud_CRUD.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decloud_CRUD.Controllers
{
    //[Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee employeeDataAccess;

        public EmployeeController(IEmployee _objemployee)
        {
            employeeDataAccess = _objemployee;
        }

        // GET: api/<controller>
        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return employeeDataAccess.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create([FromBody] TblEmployee employee)
        {
            return employeeDataAccess.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            return employeeDataAccess.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody]TblEmployee employee)
        {
            return employeeDataAccess.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return employeeDataAccess.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return employeeDataAccess.GetCities();
        }
    }
}
