using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgos
{
    public class logical1
    {

        public int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }

        public void printFibbo(int number)
        {
            for (int counter = 0; counter < number; counter++)
            {
                Console.WriteLine(" \n" + Fibonacci(counter));
            }
                
        }

        public void FibonacciNew(int a, int b, int cnt,int num)
        {
            Console.WriteLine(a);
            if (cnt < num)
            {
                 FibonacciNew(b, a + b, cnt + 1, num);
            }
        }

        public void FibonacciIterate(int num)
        {
            int a = 0; int b = 1;
            for(int i  = 2; i < num;i++)
            {
                int temp = b;
               
                b = a + b;
                a = temp;
                Console.WriteLine(b);

            }
        }

        public void printFibboNew(int number)
        {
            FibonacciNew(0, 1, 1, number);
        }


        public int factorial(int num)
        {

            if(num == 1)
            {
                return 1;
            }
            else
            {
                return num * factorial(num - 1);
            }



        }
    }
}
