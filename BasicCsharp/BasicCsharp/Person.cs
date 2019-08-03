using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCsharp
{
    public class Person
    {
        public string Name { get; set; }
        public int Salary { get; set;  }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
                return false;

            var other = obj as Person;

            if (Name != other.Name || Salary != other.Salary)
                return false;

            return true;
        }

        public static bool operator ==(Person x, Person y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Person x, Person y)
        {
            return !(x == y);
        }
    }
}
