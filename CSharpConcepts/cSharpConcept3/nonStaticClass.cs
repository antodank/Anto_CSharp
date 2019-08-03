using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept3
{
    public class nonStaticClass
    {
        public static int counter = 0;

        public static void DoSomething()
        {
            Console.WriteLine("DoSomething Static");
        }


        public void DoSomethingMore()
        {
            Console.WriteLine("DoSomethingMore Static");
        }

        public void PrintCounter()
        {
            counter++;
            Console.WriteLine(counter.ToString()); 
        }

        public static void PrintCounterStatic()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
    }
}
