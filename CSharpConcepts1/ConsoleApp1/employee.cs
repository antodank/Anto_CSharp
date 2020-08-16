using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public string id;
        public string name;
        public Department department;

        public Employee shallowCopy()
        {
            Employee newemp = (Employee)this.MemberwiseClone();
            return newemp;

        }

        public Employee deepCopy()
        {
            Employee newemp = (Employee) this.MemberwiseClone();
            newemp.department = new Department();
            return newemp;

        }

        public Employee deepCopy1()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (Employee)formatter.Deserialize(ms);
            }
        }
    }

    public class Department
    {
        public string id;
    }
}
