using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;  

namespace ParallelApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("{0}",i);
            //    Thread.Sleep(100);  
            //}

            //Thread.Sleep(2000);
            //Console.WriteLine("====");

            //Parallel.For(0, 10, (i) =>
            //{
            //    Console.WriteLine("{0}", i);
            //    Thread.Sleep(100); 
            //});


            //char[] charr = {'A','B','C','D','E','F','H','I','J','K' };

            //foreach (char ch in charr)
            //{
            //    Console.Write("{0}",ch.ToString());
            //    Thread.Sleep(100);  
            //}

            //Thread.Sleep(2000);
            //Console.WriteLine("====");

            //Parallel.ForEach(charr, (c) =>
            //{
            //    Console.Write("{0}", c.ToString());
            //    Thread.Sleep(100);
            //});

             

            var numbers = Enumerable.Range(0, 1000);
            var parResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var item in parResult)
            {
                 Console.WriteLine("{0}",item.ToString());
            }

            Console.ReadKey(); 
        }
    }
}
