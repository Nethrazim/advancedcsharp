using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Asynchronous
{
    /*
     * Using the async and await Keywords
     */
    internal class AsyncSample4
    {
        public async Task Run()
        {
            Console.WriteLine("MAIN THREAD ID : " + Thread.CurrentThread.ManagedThreadId);
            //ExecuteTaskOne();
            //Task.Run(async () => await ExecuteTaskOne());
            await ExecuteTaskOne();
            Method2();
        }

        private  async Task ExecuteTaskOne()
        {
            await Task.Run(Method1);
        }

        private void Method1()
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} . Method1() has started");
            Thread.Sleep(3000);
            Console.WriteLine("Method1() has completed.");
        }

        private void Method2()
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} . Method2() has started");
            Thread.Sleep(100);
            Console.WriteLine("Method2() has completed.");
        }
    }
}
