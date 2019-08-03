using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;     

namespace TaskApplication
{
    class Program
    {
        static void TaskMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("*");
            }
        }

        static void Main(string[] args)
        {
            //// Creating Task Ananymous method========================================
            //Task t1 = Task.Run(() =>
            //    {
            //        for (int i = 0; i < 100; i++)
            //        {
            //            Console.WriteLine("*");  
            //        }
            //    });
            //// Same as join method of thread
            //t1.Wait();

            ////Creating Task with Action method==========================================
            //Task t2 = Task.Run(action: TaskMethod);
            //t2.Wait();

            ////Task Result and Task Continuation=========================================
            //Task<int> t3 = Task.Run(() =>
            //{
            //    return 100 / 2;
            //}).ContinueWith((i) =>
            //{
            //    return i.Result * 3;
            //});

            //int result = t3.Result;
            //Console.WriteLine("Task3 Result - {0}",result);  
            //t3.Wait();

            //Task<int> t4 = Task.Run(() =>
            //        {
            //            return 100/2;
            //            //throw new Exception("abc");
            //            //return 0;
            //        });
            //            try
            //            {
            //                t4.Wait();
            //            }
            //            catch (System.Exception exc)
            //            {
            //                t4.ContinueWith((res) =>
            //                {
            //                    Console.WriteLine("Fault Occurred. - {0}", exc.Message);
            //                }, TaskContinuationOptions.OnlyOnFaulted);
            //            }
            //            finally
            //            {
            //                t4.ContinueWith((res) =>
            //                {
            //                    Console.WriteLine("Task Result - {0}", res.Result);
            //                    Console.WriteLine("Task Completed.");
            //                    return res.Result; 
            //                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            //            }

            //waitall and waitany==============================================

            //Task<int>[] taskarray = new Task<int>[3];

            //taskarray[0] = Task.Run(() => { Thread.Sleep(1000); 
            //   // Console.WriteLine("Task A completed"); //for wait all
            //    return 1; });

            //taskarray[1] = Task.Run(() => { Thread.Sleep(2000); 
            //   // Console.WriteLine("Task B completed"); 
            //    return 2; });

            //taskarray[2] = Task.Run(() => { Thread.Sleep(3000);
            //    //Console.WriteLine("Task C completed"); 
            //    return 3; });

            ////Task.WaitAll(taskarray);  

            //while (taskarray.Length > 0)
            //{
            //   int itask =  Task.WaitAny(taskarray);
            //   Task<int> currentTask = taskarray[itask];
            //   Console.WriteLine("Task" + currentTask.Result.ToString() + " completed.");
            //   var temp = taskarray.ToList();
            //   temp.RemoveAt(itask);
            //   taskarray = temp.ToArray(); 
            //}

            //=  =============================================
            //ClsResource res = new ClsResource();
            //res.performTask_NoLock();
            //res.performTask_Lock();


            Func<string, int> method = Work;
            IAsyncResult cookie = method.BeginInvoke("Ankit Todankar", null, null);
            //
            // ... here's where we can do other work in parallel...
            Thread.Sleep(5000);
            //
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);

            Console.ReadKey(); 
        }

        static int Work(string s)
        {
            return s.Length;
        }
    }
}
