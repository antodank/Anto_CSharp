using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.IO;  

namespace AsnycAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string result = DownloadContent().Result;
            //Console.WriteLine(result);

            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //watch.Start();
            
            Console.WriteLine("File Reading Started");
            //readFileAsync();
            Task<int> res = readFileAsync();
            
            //readFileSync();
            //int res = readFileSync();
            //Console.WriteLine(res.ToString() );
            
            //watch.Stop();
            //long tt = watch.ElapsedMilliseconds;
            //Console.WriteLine("Time - {0}",tt.ToString() );

            while (true)
            {
                Console.WriteLine("enter something -");
                string line = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(line))
                    break;

                Console.WriteLine("You Typed - " + line);
            }

            res.Wait();
            int result = res.Result ;
            Console.WriteLine("Task result - " + result.ToString() );

            //BlockingCollectionMethod();
            
            Console.ReadKey(); 

        }

        static int readFileSync()
        {
            string file = @"D:\HPE\cases\bankoftokyo\logs170629\Log\3PARPROV1.log";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            using (StreamReader reader = new StreamReader(file))
            {
                string v = reader.ReadToEnd();
                count += v.Length;

                for (int i = 0; i < 100; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFileSync exit with count - " + count.ToString()  );
            return count;

        }

        static async Task<int> readFileAsync()
        {
            string file = @"D:\HPE\cases\bankoftokyo\logs170629\Log\3PARPROV.log";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the filed at a somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 100; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("ReadFileAsync exit count - " + count.ToString()  );
            return count;
        }

        public static async Task<string> DownloadContent()
        {
            string result = string.Empty;  
            using(HttpClient client = new HttpClient())
            {
                Uri url = new Uri("http://www.microsoft.com");
                result = await client.GetStringAsync(url);
               
            }

            return result;
        }

        public  static void BlockingCollectionMethod()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }

    }
}
