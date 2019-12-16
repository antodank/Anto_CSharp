using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateProject
{
    class Program
    {
        //delegates declared
        public delegate void delMethodPtr();
        public delegate void delParamMethodPtr(string name);
       
        static void Main(string[] args)
        {
            //delMethodPtr delptr = new delMethodPtr(DoSomething);
            //delptr.Invoke();

            //delParamMethodPtr delParamptr = new delParamMethodPtr(DoSomething);
            //delParamptr.Invoke("Ankit");

            //demoClass objclass = new demoClass();
            //objclass.LongTask(callback);

            List<Employee> lstEmp = new List<Employee>()
            {
                new Employee { EmpID = 101, Emp_Name = "Ankit",city = "Mumbai" },
                new Employee { EmpID = 102, Emp_Name = "Viraj", city = "Thane" },
                new Employee { EmpID = 103, Emp_Name = "Neeta", city = "Kalyan" }
                
            };

            Employee empres1 = lstEmp.Find(delegate(Employee e) { 
                return e.EmpID == 102;
            }); 


            //Using lambda expression
            Employee empres2 = lstEmp.Find(e1 => e1.EmpID == 102);

            var enumemp =  lstEmp.Select(e => e.Emp_Name.StartsWith("A")) ;
   


            Console.ReadLine();

        }

        static void DoSomething()
        {
            Console.WriteLine("DoSomething Called.");
        }

        static void DoSomething(string name)
        {
            Console.WriteLine("Hi " + name + ", DoSomething Called."); 
        }

        static void callback(int i)
        {
            Console.WriteLine(i.ToString());

        }
    }

    public class demoClass
    {
        //callback delegate
        public delegate void callback(int i);

        public void LongTask(callback obj)
        {
            for (int i = 1; i <= 10000; i++)
            {
                obj(i);
            }
        }
    }


}
 