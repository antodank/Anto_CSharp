using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parent
    {
        public void Method()
        {
            Console.WriteLine("Parent - Method");
        }

        public virtual void MethodA()
        {
            Console.WriteLine("Parent - MethodA");
        }

        public virtual void MethodB()
        {
            Console.WriteLine("Parent - MethodB");
        }
    }


    public class child : Parent
    {
        public void Method()
        {
            Console.WriteLine("Child - Method");
        }

        //access level and return type of the overrided member can be differ
        protected new void MethodA()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("I am in MethodA of child");
            builder.AppendLine("I am declared with keyword new");
            builder.AppendLine("I have diffrent signature.");
            builder.AppendLine("Thanks");

            Console.WriteLine(builder.ToString());
        }

        //method signature, access level and return type of the overrided member has to be same as the base class member
        public override void MethodB()
        {
            Console.WriteLine("Child - MethodB");
        }

        public void MethodC()
        {
            Console.WriteLine("Child - MethodC");
        }
    }
}
