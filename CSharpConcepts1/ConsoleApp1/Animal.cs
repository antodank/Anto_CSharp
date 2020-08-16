using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ABC : IAnimal, IBirD
    {
        public void eat()
        { Console.WriteLine("I am a"); }

        public void shit() => Console.WriteLine("I am a");
    }

    interface IBirD
    {
        void eat();
    }

    interface IAnimal
    {
        void eat();
    }
}
