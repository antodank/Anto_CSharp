using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApplication
{
    class ClsResource
    {
        public void performTask_NoLock()
        {
            int n = 0;

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000; i++)
            {
                n--;
            }

            t1.Wait();

            Console.WriteLine(n.ToString());  
        }

        public void performTask_Lock()
        {
            object _lock = new object(); 
            int n = 0;

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    lock (_lock)
                    n++;
                }
            });

            for (int i = 0; i < 1000; i++)
            {
                lock(_lock)
                n--;
            }

            t1.Wait();

            Console.WriteLine(n.ToString());
        }

    }
}
