using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
    //Lambda can access context variables so you can return a value from the child thread. 
    internal class ThreadSample2
    {
        public void Run()
        {
            int myInt = 0;
            Thread threadOne = new Thread(() => {
                Console.WriteLine($"Method1() is executing in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
                myInt = 5;
            });
            threadOne.Start();
            threadOne.Join(); //Try with Join() or without and see the difference in myInt
            Console.WriteLine("myInt = " + myInt);
        }
    }
}
