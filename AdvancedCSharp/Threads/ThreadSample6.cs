using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
   
    //Deadlocks
    internal class ThreadSample6
    {
        class SharedResource
        {
            private object myFirstLock = new object();
            private object mySecondLock = new object();

            public void SharedMethodOne()
            {
                lock (myFirstLock)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " has entered into first part of SharedMethodOne.");
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " cannot enter next part.");

                    lock (mySecondLock)
                    {
                        Console.Write(Thread.CurrentThread.Name + " has entered into last part of SharedMethodOne.");
                        Thread.Sleep(1000);

                    }
                }
            }

            public void SharedMethodTwo()
            {
                lock (mySecondLock)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " has entered into first part of SharedMethodTwo.");

                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " cannot enter next part.");
                    lock (myFirstLock)
                    {
                        Console.Write(Thread.CurrentThread.Name + " has entered into last part of SharedMethodTwo.");
                        Thread.Sleep(1000);
                    }
                }
            }
        }


        public void Run()
        {
            Thread.CurrentThread.Name = "Main Thread";

            SharedResource sharedObject = new SharedResource();
            
            Thread threadOne = new Thread(sharedObject.SharedMethodOne);
            threadOne.Name = "Child Thread-1";

            Thread threadTwo = new Thread(sharedObject.SharedMethodTwo);
            threadTwo.Name = "Child Thread-2";

            threadOne.Start();
            threadTwo.Start();

            threadOne.Join();
            threadTwo.Join();
        }
    }
}
