using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using ProjectTrackingServices.Models;


namespace ProjectTrackingServices.Controllers
{
    [EnableCors(origins: "http://localhost:55058", headers: "*", methods: "*")]
    public class PTEmployeesController : Controller
    {
        // GET: Employees
        [Route("api/ptemployees")]
        [HttpGet]
        public HttpResponseMessage  Get()
        {
            var employees = EmployeesRepository.GetAllEmployees();
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response; 


        }

        [Route("api/ptemployees/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var employees = EmployeesRepository.GetEmployeesByID(id);
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees/{name:alpha}")]
        [HttpGet]
        public HttpResponseMessage Get(string name)
        {
            var employees = EmployeesRepository.GetEmployeeByName(name);
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees")]
        public HttpResponseMessage Post(Employee e)
        {
            var employees = EmployeesRepository.InsertEmployee(e);
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees")]
        public HttpResponseMessage Put(Employee e)
        {
            var employees = EmployeesRepository.UpdateEmployee(e);
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees")]
        public HttpResponseMessage Delete(Employee e)
        {
            var employees = EmployeesRepository.DeleteEmployee(e);
            HttpRequestMessage request = new HttpRequestMessage();
            var response = request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }
    }
}
