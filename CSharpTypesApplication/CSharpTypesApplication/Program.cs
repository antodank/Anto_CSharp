using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypesApplication
{
    public delegate void myDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            //enum 
            MyDays d = MyDays.Mon;
            Console.WriteLine((int)d);

            Product objp = new Product();
            objp.Price = 10;

            Console.WriteLine(objp.Discount().ToString());

            Point structP = new Point(10, 20);
            structP.len = 15;
            structP.bdth = 25;

            Console.WriteLine(structP.area.ToString());

            ClassA objA = new ClassA();
            myDelegate mydel = new myDelegate(objA.Add);
            mydel(25, 15);

            myDelegate mydel1 = objA.Subtract;
            mydel1(30, 15);

            Action<string> action = new Action<string>(objA.Display);
            action("Hello!!!");

            Func<int, int,int> func = new Func<int, int, int>(objA.Area);
            Console.WriteLine(func(10, 20).ToString());

            List<Customer> custList = new List<Customer>()
            {
                new Customer() { Id = 1001,FullName = "Ankit Todankar",City = "Thane" },
                new Customer() { Id = 1002,FullName = "Viraj Todankar",City = "Thane" },
                new Customer() { Id = 1003,FullName = "Rohit Sharma",City = "Mumbai" }
            };

            Predicate<Customer> mypredicate = x => x.Id == 1002;

            Customer cust = custList.Find(mypredicate);

            Console.ReadKey();  

        }
    }

   



}