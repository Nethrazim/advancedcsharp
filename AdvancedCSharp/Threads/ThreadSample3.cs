using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
    //Thread priority means how frequently a thread can get CPU time
    internal class ThreadSample3
    {
        //Thread priorities
        public void Run()
        {
            Thread threadOne = new Thread(Method1);
            threadOne.Name = "Child Thread-1";
            threadOne.Priority = ThreadPriority.AboveNormal;
            threadOne.Start();
        }

        void Method1()
        {
            Console.WriteLine("Thread Name is: {0}, inside Method1()", Thread.CurrentThread.Name);
            Console.WriteLine("ManagedThreadId is: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread Priority: is: {0}", Thread.CurrentThread.Priority);
            
            foreach(int i in new int[] { 1, 2, 3, 4, 5 })
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
        }
    }
}
