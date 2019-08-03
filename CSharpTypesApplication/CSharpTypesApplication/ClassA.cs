using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypesApplication
{
    public class ClassA
    {
        public void Add(int a, int b)
        {
           int c = a + b;
        }

        public void Subtract(int a, int b)
        {
            int c = a - b;
        }

        public void Display(string message)
        {

            Console.WriteLine(message);

        }

        public int Area(int length, int breadth)
        {
            return length * breadth;
        }
    }
}
