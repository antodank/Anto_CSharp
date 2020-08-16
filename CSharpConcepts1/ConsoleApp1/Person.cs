using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public int Age;
        public string Name;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
