using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept3
{
    public abstract class Animal
    {


        public Animal(bool mamal, bool herbivores)
        {
            IsMammal = mamal;

            IsHerbivores = herbivores; 

        }

        public bool IsMammal { get; set;  }
        public bool IsHerbivores { get; set; }

        public abstract string MakeSound();

    }

    public class Cow : Animal
    {
        public Cow() : base(true, true) { }
        public override string MakeSound()
        {
            return "Hamaaa";
        }
    }

    public class Dog : Animal
    {
        public Dog() : base(true, false) { }

        public override string MakeSound()
        {
            return "Bhu bhu";
        }
    }

    public class Duck : Animal
    {
        public Duck() : base(false, false) { }
        public override string MakeSound()
        {
            return "Kwack kwack";
        }
    }
}
