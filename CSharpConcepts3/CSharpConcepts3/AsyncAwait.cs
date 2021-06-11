using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts3
{
    public class AsyncAwait
    {
        //Use the async modifier to specify that a method, lambda expression, or anonymous method is asynchronous.
        //If the method that the async keyword  doesn't contain an await expression or statement, the method executes synchronously.
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1 : " + DateTime.Now.Millisecond);
                }
            });
        }
        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 2 : " + DateTime.Now.Millisecond);
                }
            });
        }

        //CPU Bound
        static int Calculate()
        {
            // calculate total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 100000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
                Task.Delay(100);
            }
            return size;
        }

        public static async void Execute()
        {
            // running this method asynchronously.
            int t = await Task.Run(() => Calculate());
            Console.WriteLine("Result: " + t);
        }

        public static async Task SlowLoop()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Task.Delay(1000).Wait();
                    Console.WriteLine(DateTime.Now.Millisecond);

                }

            });
        }

        public static async void callMethod()
        {
            Task<int> task = Method3();
            Method1();
            int count = await task;
            Method4(count);
        }

        public static async Task<int> Method3()
        {
            return await Task.Run(() => Calculate());

        }

        public static void Method4(int count)
        {
            Console.WriteLine("Total count is " + count );
        }

        public static async Task<int> ExampleMethodAsync()
        {
            Console.WriteLine("HTTP request sent");
            var httpClient = new HttpClient();
            int exampleInt = (await httpClient.GetStringAsync("https://reqres.in/api/users")).Length;
            Console.WriteLine("Data Received.");
            return exampleInt;
        }


    }
}
