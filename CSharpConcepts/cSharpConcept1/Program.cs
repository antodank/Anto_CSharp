using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region null types
            //object nullValue = null;
            //Type nullType = nullValue.GetType(); // Run time error - NullReferenceException
            //you can’t call GetType() on a null value

            // -- Nullable allows to assign a null value to a variable 
            //Nullable types can only work with Value Type

            //int intValue = 5;
            ////intValue = null; // compile time error

            //Nullable<int> nullableIntValue = 5;
            //nullableIntValue = null;
            //DateTime? dtpStart = null;
            //DateTime newDate = dtpStart.GetValueOrDefault(); //== 01/01/00001
            //int newVal = nullableIntValue.GetValueOrDefault();

            //Type type1 = intValue.GetType();
            //nullableIntValue = 10;
            //Type type2 = nullableIntValue.GetType(); // Run time error if null 

            //bool areTypesEqual = intValue.GetType() == nullableIntValue.GetType(); 

            #endregion

            #region Interface Implementation
            // Implicit and Explicit Interface Implementation
            // Use it when you want to implement two interfaces with the same signatures and 
            // have different implementations

            ////shows getDate() Implicit interface Implementation
            //DefaultDateProvider defprovider = new DefaultDateProvider();
            //DateTime dtime = defprovider.GetDate();

            //// getDate() is not available bcoz it is declared as explicit
            //MinDateProvider provider = new MinDateProvider();
            ////provider

            //////shows getDate() bcoz class is treated as implemented interface
            //IDateProvider iprovioder = new MinDateProvider();
            //iprovioder.GetDate();

            //MyDateProvider myprovider = new MyDateProvider();
            //myprovider.GetDate(); 
            #endregion

            //Generic

            //TestClass<int> objint = new TestClass<int>();
            //objint.Add(50);

            //TestClass<string> objstr = new TestClass<string>();
            //objstr.Add("hello");

            //int a = 40, b = 60;
            //Console.WriteLine("Before swap: {0}, {1}", a, b);
            //objint.Swap<int>(ref a, ref b);
            //Console.WriteLine("After swap: {0}, {1}", a, b);

            //string astr = "Ankit";
            //string bstr = "Viraj";
            //Console.WriteLine("Before swap: {0}, {1}", astr, bstr);
            //objstr.Swap<string>(ref astr, ref bstr);
            //Console.WriteLine("After swap: {0}, {1}", astr, bstr);

            //MyGenArray<int> intArray = new MyGenArray<int>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    intArray.setItem(c, c * 5);
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.getItem(c) + " ");
            //}

            ////declaring a character array
            //MyGenArray<char> charArray = new MyGenArray<char>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.setItem(c, (char)(c + 97));
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.getItem(c) + " ");
            //}

            #region new and overrride
            //==============================================================
            // new keyword is assertion of hiding a method which is inherited from the base class.
            // override modifier extends the base class method

            DerivedClass objderived = new DerivedClass();

            objderived.VirtualMethod();
            objderived.NormalMethod();

            BaseClass objBase = new DerivedClass();

            objBase.VirtualMethod();
            objBase.NormalMethod();

            //===============================================================

            #endregion

            //structures
            //Car car;

            //car = new Car("Blue");
            //Console.WriteLine(car.Describe());

            //car = new Car("Red");
            //Console.WriteLine(car.Describe());

            //Bike objbike = new Bike();
            //Console.WriteLine(objbike.GetGears());  

            //Nested

            //Container.Nested objnest = new Container.Nested();

            //======================

            //List<Pet> objpets = new List<Pet>();
            //objpets.Add(new Dog());
            //objpets.Add(new Cat());
            //objpets.Add(new Bird());

            //foreach (Pet objpet in objpets)
            //    objpet.speak(); 


            //=========================

            Math objmat = new Math();
            objmat.division();  

            Console.ReadLine();


        }



    }


    //struct are value type
    struct Car
    {
        private string color;

        //fields can't have initializers
        //private string Engine = "2000cc";

        //If you declare a constructor, all fields must be assigned to before leaving the constructor
        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    //struct doesnt support parameterless constructor other than default
    //struct can not inherite from other struct or class
    //Class can not inherite struct
    //struct supports interface

    public struct Bike : ITwoWheeler
    {
        // Fields
        private string model;
        private int Gears;

        // Property
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        // Method
        public int GetGears()
        {
            Gears = 5;
            return Gears;
        }
    }

    interface ITwoWheeler
    {

    }

    
}
