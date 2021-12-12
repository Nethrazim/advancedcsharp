using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Asynchronous
{
    /*
     * In simple terms , you take a code segment and run it on a separate thread.
     * Using a ThreadPool, a brief introduction
     */
    internal class AsyncSample1
    {
        public void Run()
        {
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Method2));
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Method3), 10);

            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback((number) => {
                Console.WriteLine("Qeue lambda :" + number);
            }), 103);
            Console.WriteLine("End MainThread");
        }

        public delegate void WaitCallback(object state);
        private void Method1()
        {
            Console.WriteLine("-Method1() has started");
            Thread.Sleep(1000);
            Console.WriteLine("Method1() has finished");
        }

        private void Method2(object state)
        {
            Console.WriteLine("-Method2() has started");
            Thread.Sleep(100);
            Console.WriteLine("Method2() has finished");
        }

        private void Method3(object number)
        {
            Console.WriteLine("---Method3() has started.");
            int upperLimit = (int)number;
            for (int i = 0; i < upperLimit; i++)
            {
                Console.WriteLine("---Method3() prints 3.0{0}", i);
            }
            Thread.Sleep(100);
            Console.WriteLine("---Method3() has finished.");
        }
    }
}
