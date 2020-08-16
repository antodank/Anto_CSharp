using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 10; int b = 8;

            sorting objsort = new sorting();

            //objsort.swap( a,  b);

            //int[] arr = { 18,33,99,22,65,92,12,56,47 };

            ////objsort.bubbleSort(ref arr);

            ////objsort.selectionSort(ref arr);

            //NewSorting objnewsort = new NewSorting();

            ////objnewsort.bubblesort(ref arr);

            ////objnewsort.selectionSort(ref arr);

            //objnewsort.quickSort(ref arr, 0, arr.Length - 1);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Problem1 problem1 = new Problem1();
            string result = string.Empty;
            result = problem1.toBinary(65);

            problem1.isPowerNum(625, 5);

            problem1.binaryAdd(3, 5);

            logical1 logic1 = new logical1();
            //logic1.printFibbo(10);
            //logic1.printFibboNew(10);
            logic1.FibonacciIterate(10);

            Console.WriteLine("Recursion - " + logic1.factorial(6));

            Console.ReadLine();
        }
    }
}
