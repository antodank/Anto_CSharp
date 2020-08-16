using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void delCallBack(string taskResult);
    public class CallBack
    {
        public void StartNewTask(delCallBack taskCompletedCallBack)
        {
            Console.WriteLine("I have started new Task.");
            if (taskCompletedCallBack != null)
                taskCompletedCallBack("I have completed Task.");
        }
    }

    public class CallBackA
    {
        public void methodcallbackA(string result) => Console.WriteLine("via callbackA " + result);
    }

    public class CallBackB
    {
        public void methodcallbackB(string result) => Console.WriteLine("via callbackB" + result);
    }

}
