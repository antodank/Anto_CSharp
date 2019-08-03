using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static readonly object locker = new object();

        static void Main(string[] args)
        {
            // creating object of my class.
            MyClass obj = new MyClass();

            //Creating a new thread.
            //Thread t1 = new Thread(obj.Fun);

            //t1.Start(); // starting a new thread.

            //// Simultaneously, do something on the main thread.
            //for (int j = 0; j < 100; j++)
            //{
            //    Console.WriteLine("Main Thread -> j: " + j);
            //    Thread.Sleep(200);
            //}

            //Thread th1 = new Thread(obj.Fun1);
            //Thread th2 = new Thread(obj.Fun2);
            //Thread th3 = new Thread(obj.Fun3);

            //th1.Name = "th1";
            //th2.Name = "th2";
            //th3.Name = "th3";

            //th1.Start();
            //th2.Start();
            //th3.Start();

            //Thread.Sleep(5000);

            //obj.done = true;   


            //Thread th4 = new Thread(obj.Fun4);
            //Thread th5 = new Thread(obj.Fun4);
            //th4.Name = "th4";
            //th5.Name = "th5";

            //th4.Start();
            //th5.Start();

            //Thread th6 = new Thread(obj.Print);
            //th6.Start("Ankit");

            //new Thread(() =>
            //{
            //    Console.WriteLine("I'm running on first thread!");
            //    Console.WriteLine("This is so easy!");
            //}).Start();

            //new Thread(delegate ()
            //{
            //    Console.WriteLine("I'm running on second thread!");
            //    Console.WriteLine("This is so easy!");
            //}).Start();

            try
            {
                new Thread(obj.Fun5).Start();
            }
            catch (Exception ex)
            {
                // We'll never get here!
                Console.WriteLine("Exception!");
            }

            Console.ReadLine();

        }

        class MyClass
        {
           public  bool done;

            public void Fun()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Thread t1 -> i: " + i);
                    Thread.Sleep(200);
                }
            }

            public void Fun1()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Name: " + Thread.CurrentThread.Name + "  " + i);
                    Thread.Sleep(300);
                }
            }

            public void Fun2()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Name: " + Thread.CurrentThread.Name + "  " + i);
                    Thread.Sleep(400);
                }
            }

            public void Fun3()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (done)
                    {
                        Console.WriteLine("Done");
                        i = 100;
                    }
                    else
                    {

                        Console.WriteLine("Name: " + Thread.CurrentThread.Name + "  " + i);
                        Thread.Sleep(500);
                    }
                }
            }

            public void Fun4()
            {
                lock (locker) //exclusive lock allows only one thread at a time
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Name: " + Thread.CurrentThread.Name + "  " + i);
                        Thread.Sleep(400);
                    }
                }
            }

            public void Print(object messageObj)
            {
                string message = "Hi " + (string)messageObj;   // We need to cast here
                Console.WriteLine(message);
            }

            public void Fun5()
            {
                int j = 0;
                int i = 5 / j;
            }

        }

    }
}
