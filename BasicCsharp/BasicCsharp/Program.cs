using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? dtp= null;

            if (dtp == null)
            {

            }


            //// compile time error - objA can not be converted to objB
            //classA objA = new classA();
            //classB objB = objA as classB;

            //clsDemo objDemo = new clsDemo();
            //objDemo.DoSomeWork();

            #region capacity...

            //int[] iarr = new int[3]; 

            //The capacity of a collection is the number of elements that can be added to the collection
            //before resizing is necessary.
            //we don't specify a capacity, the buffer will be reallocated as we keep adding elements. 
            //This makes populating a Dictionary or List much slower.

            //List<int> objlist = new List<int>(3);

            //objlist.Add(1);
            //objlist.Add(2);
            //objlist.Add(3);
            //objlist.Add(4);

            //// Printing the Capacity 
            //Console.WriteLine("Capacity Is: " + objlist.Capacity);

            //// Printing the Count
            //Console.WriteLine("Count Is: " + objlist.Count);

            //objlist.Add(5);
            //objlist.Add(6);
            //objlist.Add(7);
            //objlist.Add(8);
            //// Printing the Capacity 
            //Console.WriteLine("After Capacity Is: " + objlist.Capacity);

            //// Printing the Count
            //Console.WriteLine("After Count Is: " + objlist.Count);

            #endregion


            #region Function Optional Parameter

            //Class10 obj10 = new Class10();

            ////named parameter
            //obj10.Add(Num2: 10 , Num1: 15);

            //obj10.multiply(10,Num2:5);

            ////optional
            //obj10.Add(5,10,15);

            ////param
            //obj10.Add(5, 10, 15,12,15);

            #endregion

            #region MyRegion

            //ClassTryCatch objTryCatch = new ClassTryCatch();

            //try
            //{
            //    //objTryCatch.Func1();
            //    //objTryCatch.Func2();
            //    //objTryCatch.Func3();
            //    //objTryCatch.Func4();
            //    //objTryCatch.Func5();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            #endregion


            #region MyRegion

            Person p1 = new Person { Name = "Ankit", Salary = 150000 };
            Person p2 = p1;
            Person p3 = new Person { Name = "Ankit", Salary = 150000 };

            Console.WriteLine(p1.Equals(p2));  // True
            Console.WriteLine(p1 == p2);       // True

            Console.WriteLine(p1.Equals(p3));  // False (When equals not overloaded)
            Console.WriteLine(p1 == p3);       // False (When == not overloaded)

            #endregion

            Console.ReadKey();  
        }
    }

    public class classA
    {
    }

    public class classB
    {
    }


    public interface IDemo
    {
        void DoSomeWork();
    }

    public abstract class claABDemo : IDemo
    {
        public abstract void DoSomeWork();
    }

    public class clsDemo : claABDemo
    {

        public clsDemo()
        {
            Console.WriteLine("I am in clsDemo constructor."); 
        }

        public override void DoSomeWork()
        {
            Console.WriteLine("I am in DoSomeWork.");   
        }

    }

}
