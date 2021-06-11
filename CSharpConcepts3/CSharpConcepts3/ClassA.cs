using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts3
{
    public class ClassA
    {
    }


    public class ClassD
    {
        public virtual void DoWork(int i)
        {
            // Original implementation.
            Console.WriteLine($"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name} - {i}");
        }
    }

    //The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.
   
    //An abstract class cannot be instantiated. 
    public abstract class ClassE : ClassD
    {
        public void DoRest()
        {
            Console.WriteLine($"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name} - Resting....");
        }

        //An abstract method is implicitly a virtual method.
         //there is no method body; the method declaration simply ends with a semicolon
        //It is an error to use the static or virtual modifiers in an abstract method declaration.
        public abstract void DoSpeak(string str);
        public abstract override void DoWork(int i);
    }

    public class ClassF : ClassE
    {
        public override void DoWork(int i)
        {
            // New implementation.
            Console.WriteLine($"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name} - {i}");
        }

        public override void DoSpeak(string str)
        {
            Console.WriteLine($"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name} - {str}");
        }
    }

    //The sealed keyword enables you to prevent the inheritance of a class or certain class members that were previously marked virtual.
    public sealed class ClassG
    {
        // Class members here.
    }

    //public class ClassH : ClassG

    // eg of sealed member
    public class ClassH : ClassD
    {
        public sealed override void DoWork(int i) {
            Console.WriteLine($"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod().Name} - {i}");
        }
    }

    // you can not override further


}
