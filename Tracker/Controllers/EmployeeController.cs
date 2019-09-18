using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tracker.Model;

namespace Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly TrackerContext trackerContext;

        public EmployeeController(TrackerContext context)
        {
            trackerContext = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return trackerContext.Employees.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(string id)
        {
            Employee empFilter = trackerContext.Employees.SingleOrDefault(emp => emp.EmployeeID == id);

            if (empFilter == null)
            {
                return NotFound("Employee not found");
            }
            else
            {
                return empFilter;
            }
        }
       
        [HttpPost]
        public ActionResult Post(Employee employee)
        {

            if (ModelState.IsValid)
            {
                trackerContext.Add(employee);
                trackerContext.SaveChanges();
                return Ok("Added Successfully");
            }
            else
            {
                return BadRequest();
            }
                
        }

        [HttpPut]
        public ActionResult Put(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee empFilter = trackerContext.Employees.SingleOrDefault(emp => emp.EmployeeID == employee.EmployeeID);

                if (empFilter == null)
                {
                    return NotFound("Employee not found");
                }
                else
                {
                    empFilter.EmployeeName = employee.EmployeeName;
                    empFilter.Email = employee.Email;
                    trackerContext.SaveChanges();
                    return Ok("Updated Successfully");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            Employee empFilter = trackerContext.Employees.SingleOrDefault(emp => emp.EmployeeID == id);

            if (empFilter == null)
            {
                return NotFound("Employee not found");
            }
            else
            {
                trackerContext.Employees.Remove(empFilter);
                trackerContext.SaveChanges();
                return Ok("Deleted Successfully");
            }
        }

    }
}