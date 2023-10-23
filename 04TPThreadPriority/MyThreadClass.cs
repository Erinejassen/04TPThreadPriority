using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04TPThreadPriority
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {

            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(500);
            }

        }
        public static void Thread2() 
        {
            for (int x = 0; x <= 5; x++)
            {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + x);
                Thread.Sleep(1500);
            }
        }
    }
}
