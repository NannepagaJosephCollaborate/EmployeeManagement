using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Web.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            employee.EmployeeId = DataBase.Employees.Any() ?
                DataBase.Employees.Max(x => x.EmployeeId) + 1 : 1;
            DataBase.Employees.Add(employee);

            return RedirectToAction("GetEmployees");
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return View();
        }

    }
}
