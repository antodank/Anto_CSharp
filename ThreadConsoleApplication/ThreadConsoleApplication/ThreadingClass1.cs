using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;  

namespace ThreadConsoleApplication
{
    public class ThreadingClass1
    {
       // [ThreadStatic] 
        static int _Field=0;

        public Thread threadA;
        public Thread threadB;
 

        public void methodThreadA()
        {
            threadA = new Thread(() =>
            {
                for(int i =0; i < 10;i++)
                {
                    _Field += 10;
                    Console.WriteLine("ThreadA - {0}", _Field);
                    Thread.Sleep(500);  
                }
            });

            threadA.Start(); 
        }

        public void methodThreadB()
        {
            threadB = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _Field += 10;
                    Console.WriteLine("ThreadB - {0}", _Field);
                    Thread.Sleep(500);
                }
            });

            threadB.Start();
        }
    }
}
