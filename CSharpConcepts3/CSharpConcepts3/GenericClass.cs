using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts3
{
    public class GenericClass<T> where T : class
    {
        public T GenericVariable
        {
            get;
            set;
        }

        public void showMe()
        {
            Console.WriteLine($"{typeof(T).Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        public void genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
        }

        public void AddtoList<T>(T item,Type type)
        {
            
        }

    }


    public class Gen1 : GenericClass<Employee>
    {

    }

    public class Gen2 : GenericClass<Department>
    {

    }

    //class GenericClass
    //{
    //    void Add<T>(T item) where T : class, new();

    //}

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }


}
