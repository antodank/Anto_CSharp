using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept2
{
    class Program
    {
        public delegate void myDelegate(string pet);

        public static void print1(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {

            myDelegate mydel = new myDelegate(print1);
            mydel("Ankit");

            myDelegate mydel2 = print1;
            mydel2("Viraj");

            //An anonymous method is a method which doesn’t contain any name
            // You can use a lambda expression or an anonymous method to create an anonymous function

            myDelegate mydel3 = delegate (string s) { Console.WriteLine(s); };
            mydel3("Ram");

            //lambda expression is more prefered
            myDelegate mydel4 = (s) => { Console.WriteLine(s); };

            Console.ReadKey();
        }
    }
}
