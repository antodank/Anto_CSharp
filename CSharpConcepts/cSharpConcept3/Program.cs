using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal objA = new Cow();
            //Animal objB = new Dog();
            //Animal objC = new Duck();

            //Console.WriteLine("Cow is " + (objA.IsMammal ? "Mamal" : "not mamal").ToString() + " and " + (objA.IsHerbivores ? "Herbivores." : "not Herbivores.").ToString() +
            //                  " Their voice sounds like " + objA.MakeSound());

            //Console.WriteLine("Dog is " + (objB.IsMammal ? "Mamal" : "not mamal").ToString() + " and " + (objB.IsHerbivores ? "Herbivores." : "not Herbivores.").ToString() +
            //                  " Their voice sounds like " + objB.MakeSound());

            //Console.WriteLine("Duck is " + (objC.IsMammal ? "Mamal" : "not mamal").ToString() + " and " + (objC.IsHerbivores ? "Herbivores." : "not Herbivores.").ToString() +
            //                  " Their voice sounds like " + objC.MakeSound());

            //diff in as and cast
            //Test objtest = new Test();
            //objtest.diff_As_Cast(); 


            nonStaticClass objnonstat = new nonStaticClass();
            objnonstat.PrintCounter();
            objnonstat.PrintCounter();

            nonStaticClass.PrintCounterStatic();
            nonStaticClass.PrintCounterStatic();
            nonStaticClass.PrintCounterStatic();

            nonStaticClass objnonstat1 = new nonStaticClass();
            objnonstat1.PrintCounter();
            objnonstat1.PrintCounter();

            nonStaticClass.PrintCounterStatic(); 


            Console.ReadLine();
            


        }
    }
}
