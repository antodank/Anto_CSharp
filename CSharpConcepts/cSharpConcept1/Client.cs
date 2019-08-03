using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    public class Client
    {


    }


    //Implicit - you access the interface methods and properties as if they were part of the class.
    public class DefaultDateProvider : IDateProvider
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }

        public int YourAge()
        {
            return 0;
        }
    }


    // Explicit: you can only access methods and properties when treating the class as the implemented interface.
    public class MinDateProvider : IDateProvider
    {
        DateTime IDateProvider.GetDate()
        {
            return DateTime.MinValue;
        }
    }

    public class MyDateProvider
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }


    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("I am in base constructor."); 
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("I am in base VirtualMethod.");
        }

        public void NormalMethod()
        {
            Console.WriteLine("I am in base NormalMethod.");
        }
    }

    public class DerivedClass : BaseClass
    {
        
        public DerivedClass()
        {
            Console.WriteLine("I am in derived constructor.");
        }

        public override void VirtualMethod()
        {
            //base.VirtualMethod();
            Console.WriteLine("I am in derived VirtualMethod.");
        }

        public new void NormalMethod()
        {
            Console.WriteLine("I am in derived NormalMethod.");
        }
    }
}
