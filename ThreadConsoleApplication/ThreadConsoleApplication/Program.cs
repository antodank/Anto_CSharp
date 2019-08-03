using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;  

namespace ThreadConsoleApplication
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ThreadMethod {0}", i);
                Thread.Sleep(100); 
            }

        }

        public static void ThreadParamMethod(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("ThreadParamMethod {0}", i);
                Thread.Sleep(100);
            }

        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Main Thread Start...");

            //Thread t1 = new Thread(new ThreadStart(ThreadMethod));
            //t1.Start(); 

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main Thread - {0}", i);
            //    Thread.Sleep(100);
            //}
            //Console.WriteLine("Main Thread Loop Ends...");
            //t1.Join();

            ////ParameterizedThreadStart 
            //Thread t2 = new Thread(new ParameterizedThreadStart(ThreadParamMethod));
            //t2.Start(15);
            //t2.Join();

            //bool _isSuccess = false; 
            
            ////Using Ananymous 
            //Thread t3 = new Thread(() =>
            //{
            //    while (!_isSuccess)
            //    {
            //        Console.WriteLine("Thread3 is running...");
            //        Thread.Sleep(100);
            //    }

            //});

            //Console.WriteLine("Press any key to stop Thread3");
            //t3.Start();
            //Console.ReadKey();
            //_isSuccess = true;
            //t3.Join();

            ////ThreadStatic Attribute
            //ThreadingClass1 objclass = new ThreadingClass1();

            //objclass.methodThreadA();
            //objclass.methodThreadB();  

            //objclass.threadA.Join();
            //objclass.threadB.Join();  

            //ThreadPool

            ThreadPool.QueueUserWorkItem((s) =>
            {
                int i = 10;
                while (i > 0)
                {
                    Console.WriteLine("Thread running in ThreadPool.");
                    Thread.Sleep(100);  
                    i--;
                }
            });


            Console.WriteLine("Main Thread Ends.");
            Console.ReadKey();  

        }
    }
}
