using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept3
{
    //Non-static classes can be instantiated.
    //Static classes cannot be instantiated.
    //Non-static classes can have instance method and static methods.
    //Static classes can only have static methods.
    //Instance methods must be called on the instances of the class, not the class itself.
    //Static methods must be called on the class itself, not on the instances of the class.
    public static class staticClass
    {
        public static void DoSomething()
        {
            Console.WriteLine("DoSomething Static"); 
        }

        //compile time error - cannot declare non static method
        //public void DoSomethingNostatic()
        //{
        //    Console.WriteLine("DoSomething Static");
        //}
    }
}
