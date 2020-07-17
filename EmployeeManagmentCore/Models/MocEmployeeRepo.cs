using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentCore.Models
{
    public class MocEmployeeRepo : IEmployeeRepo
    {
        private readonly List<Employee> _employeeList;

        public MocEmployeeRepo()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){EmployeeID = 1 ,Name = "meletis",Email = "meletisfasoulis@yahoo.gr",Department = "IT"},
                new Employee(){EmployeeID = 2 ,Name = "stacy",Email = "stacy@yahoo.gr",Department = "IT"},
                new Employee(){EmployeeID = 3 ,Name = "alex",Email = "alex@yahoo.gr",Department = "IT"},
                new Employee(){EmployeeID = 4 ,Name = "george",Email = "george@yahoo.gr",Department = "IT"},

            };
        }
         
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.EmployeeID == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
