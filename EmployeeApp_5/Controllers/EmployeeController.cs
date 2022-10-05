using EmployeeApp_5.EA_DbConText;
using EmployeeApp_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp_5.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext dbContext = new EmployeeDbContext();
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            ViewBag.Departments = dbContext.Departments.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = dbContext.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            ModelState.Remove("Department");
            
            if (ModelState.IsValid)
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return View("ConfirmCreating", employee);
            }
            ViewBag.Departments = dbContext.Departments.ToList();
            return View();

        }

        public IActionResult Edit(int id)
        {
            Employee employee = dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            ViewBag.Departments = dbContext.Departments.ToList();
            return View("Create", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            ModelState.Remove("Department");

            if (ModelState.IsValid)
            {
                dbContext.Employees.Update(employee);
                dbContext.SaveChanges();
                return View("ConfirmEditing",employee);
            }
            ViewBag.Departments = dbContext.Departments.ToList();
            return View("Create", employee);
        }

        public IActionResult delete(int id)
        {
            Employee employee = dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges(true);
            return View("ConfirmDeleting", employee);
        }

       
    }
}
