using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagmentCore.Models;

namespace EmployeeManagmentCore.Controllers
{
    public class HomeController : Controller
    {        
        private IEmployeeRepo _repo;

        public HomeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public Employee GetEmployee(int id)
        {
            return _repo.GetEmployee(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _repo.GetAllEmployees();
        }

       /* public IEnumerable<Employee> Deatails() {

        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
