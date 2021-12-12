using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
    //Thread Safety
    //This is a not synchronized version
    //Run this sample multiple times to see the output
    //Threads will enter SharedMethod() any way they can . First ThreadOne, or first ThreadTwo
    internal class ThreadSample5
    {
        class SynchronziedResourceWithMonitor
        {
            private object myLock = new object();
            public void SharedMethod()
            {
                try 
                {
                    Monitor.Enter(myLock);
                    Console.Write(Thread.CurrentThread.Name + " has entered in the shared location. \n");
                    Thread.Sleep(3000);
                    Console.WriteLine(Thread.CurrentThread.Name + " exits.");
                }
                finally
                {
                    Monitor.Exit(myLock);
                }
            }
        }

        class SynchronizedResource
        {
            private object myLock = new object(); // any kind of object if it's a reference type 

            public void SharedMethod()
            {
                lock (myLock)
                {
                    Console.Write(Thread.CurrentThread.Name + " has entered in the shared location. \n");
                    Thread.Sleep(3000);
                    Console.WriteLine(Thread.CurrentThread.Name + " exits.");
                }
            }
        }

        class SharedResource
        {
            public void SharedMethod()
            {
                Console.Write(Thread.CurrentThread.Name + " has entered in the shared location. \n");
                Thread.Sleep(3000);
                Console.WriteLine(Thread.CurrentThread.Name + " exits.");
            }
        }

        public void Run()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine("Main thread has started already");

            SharedResource sharedObject = new SharedResource();
            Thread threadOne = new Thread(sharedObject.SharedMethod) { Name = "Child Thread-1" };
            Thread threadTwo = new Thread(sharedObject.SharedMethod) { Name = "Child Thread-2" };

            threadOne.Start();
            threadTwo.Start();
            threadOne.Join();
            threadTwo.Join();

            Console.WriteLine("The {0} exists now.", Thread.CurrentThread.Name);
            Console.ReadKey();
        }
    }
}
