using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    public class Pet
    {
        public virtual void speak()
        {
            Console.WriteLine("I am in default speak"); 
        }
    }

    public class Cat : Pet
    {
        public void speak()
        {
            Console.WriteLine("Meowwww");
        }
    }

    public class Dog : Pet
    {
        public new void speak()
        {
            Console.WriteLine("Bhouuuu");
        }
    }

    public class Bird : Pet
    {
        public override void speak()
        {
            Console.WriteLine("Kudukuk");
        }
    }


}
