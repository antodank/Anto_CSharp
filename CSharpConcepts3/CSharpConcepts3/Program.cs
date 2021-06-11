using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts3
{
    class Program
    {
        static void Main(string[] args)
        {
            //======================== Async Await
            //AsyncAwait.Execute();
            //AsyncAwait.callMethod();
            //Method1();
            //Method2();

            //====================== Async Await Part 2
            //Console.WriteLine("Calling API....");
            //Task<int> t1 = AsyncAwait.ExampleMethodAsync();
            ////Do something till we recive ouput
            //Console.WriteLine("Flow continue till we receive API result.");
            //t1.Wait();
            //Console.WriteLine($"API Result - {t1.Result.ToString()}");

            //================================= Abstract
            //ClassE classE = new ClassF();
            //classE.DoSpeak("Ankit");
            //classE.DoWork(10);

            //================================= Generics

            GenericClass<Employee> genericClass1 = new GenericClass<Employee>();
            genericClass1.showMe();

            GenericClass<Department> genericClass2 = new GenericClass<Department>();
            genericClass2.showMe();
            genericClass2.genericMethod(new Department() { ID = 1, Name = "Admin" });

            Gen1 gen1 = new Gen1();
            gen1.GenericVariable = new Employee() { ID = 10, Name = "Ankit" };
            gen1.showMe();


            Console.WriteLine("Press any key....");
            Console.ReadLine();
        }

    }
}
