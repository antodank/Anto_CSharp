using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class ClassAbstract
    {
        string name { get; set; }

        public ClassAbstract(string Name)
        {
            name = Name;
        }

        public abstract void MethodA();

        public  void MethodB()
        {
            Console.WriteLine("Hello " + name + " in ClassAbstract MethodB");
        }

        public virtual void MethodC()
        {
            Console.WriteLine("Hello " + name + " in ClassAbstract MethodC");
        }
    }

    public abstract class ClassAbstractNew : ClassAbstract
    {
        public ClassAbstractNew(string Name) : base(Name)
        {

        }
        public abstract void MethodE();
    }

     public class classDerived : ClassAbstract
    {
        string name { get; set; }
        public classDerived(string Name) : base(Name)
        {
            name = Name;
        }

        public override void MethodA()
        {
            Console.WriteLine("Derived Class MethodA");
        }

        public override void MethodC()
        {
            Console.WriteLine("Hello " + name + " in classDerived MethodC");
        }

        public void MethodD()
        {
            Console.WriteLine("Hello " + name + " in classDerived MethodD");
        }
    }

    //public class clssDerivedNew : ClassAbstractNew
    //{
            // you have to implement both method MethodA and MethodE
    //}
}
