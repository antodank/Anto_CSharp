using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept3
{
    public class Test
    {

        public void diff_As_Cast()
        {
            String text = "Hello hello";
            Object obj = text;

            String originalCast = ((String)obj).ToUpper();
            String originalAs = (obj as String).ToUpper();

            Employee objemp1 = new Employee();
            objemp1.ID = 1;
            objemp1.Name = "Ankit";

            Object obj1 = "Employee";
            Employee objemp2 = (Employee)obj; // will through invalid cast exception
            Employee objemp3 = obj as Employee; // will return null but will not through any exception


            //double num1 = 5.45;
            //int num2 = num1 as int;
            //as operator can be used only with nullable types or ref types
            //with value types it will give compile time error

        }
    }

    public class Employee
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
    }



    //private constructor
    //- if class contains only one private constructor then we cant instatiate
    //To restrict a class being inherited.
    // class must be containing static methods such class called as utility class
    //You can still have another public constructor to instantiate the class.
    //private constructor can have parameter
    public class Sample
    {
        int root;
        string name;
        bool flag;

        private Sample()
        {
            root = 25;
            flag = true;
        }

        public Sample(string Name)
           : this()
        {
            //flag, x, y, and z are initialized here
            name = Name;
        }

        public Sample(string Name, bool flag)
           : this(Name)   //Constructor chaining
        {
            //name, flag, x, y, and z are initialized here, but we need to change flag
            this.flag = flag;
        }
    }

    public class BaseSample
    {
        private BaseSample()
        {

        }
    }

    //not possible as class with only private constructor can not be inherit
    //public class NewSample : BaseSample 
    //{

    //}


    //A static constructor does not take access modifiers or have parameters.
    // main usage initializing any static fields associated
    //A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
    //A static constructor cannot be called directly.
    //The user has no control on when the static constructor is executed in the program.

    public class Sample1
    {
        public static int field;

        static Sample1()
        {
            field = 7;
        }
    }


}
