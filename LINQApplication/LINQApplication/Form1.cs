using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQApplication
{
    public partial class Form1 : Form
    {
        List<Employee> listEmployees;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee objEmp = new Employee();
            listEmployees = objEmp.GetAllEmployees(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {


           IEnumerable<int> listid =  listEmployees.Select(emp => emp.EmployeeID);

           IEnumerable<int> listid1 = from emp in listEmployees
                    select emp.EmployeeID;

           List<string> firstNames = listEmployees.Select(emp => emp.FirstName).ToList();

           List<string> fNames = (from emp in listEmployees
                                       select emp.FirstName).ToList() ;

           var result1 = listEmployees.Where(emp => emp.Salary > 50000).Select(emp => new { ID = emp.EmployeeID, name = emp.FirstName + " " + emp.LastName });

           var result2 = from emp in listEmployees
                         where emp.Salary > 50000
                         select new 
                         {
                             ID = emp.EmployeeID,
                             name = emp.FirstName + " " + emp.LastName 
                         };

           var result3 = from emp in listEmployees
                         where emp.Salary > 50000
                         select new 
                         {
                             emp.EmployeeID,
                             emp.FirstName ,
                             emp.LastName
                         };
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            IEnumerable<string> result = (from country in countries
                                          select country).Take(3);


        }


    }
}
