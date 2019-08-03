using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApplication
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 101,
                    FirstName = "Tom",
                    LastName = "Daely",
                    Gender = "Male",
                    Salary = 60000
                },
                new Employee
                {
                    EmployeeID = 102,
                    FirstName = "Mike",
                    LastName = "Mist",
                    Gender = "Male",
                    Salary = 72000
                },
                new Employee
                {
                    EmployeeID = 103,
                    FirstName = "Mary",
                    LastName = "Lambeth",
                    Gender = "Female",
                    Salary = 48000
                },
                new Employee
                {
                    EmployeeID = 104,
                    FirstName = "Pam",
                    LastName = "Penny",
                    Gender = "Female",
                    Salary = 84000
                },
            };

            return listEmployees;
        }
    }
}
