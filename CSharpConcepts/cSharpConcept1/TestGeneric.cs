using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    public class TestClass<T>
    {
        // define an Array of Generic type with length 5
        T[] obj = new T[5];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
