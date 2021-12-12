using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Asynchronous
{
    internal class AsyncSample3
    {
        public void Run()
        {
            Console.WriteLine("Start Main Thread ID : " + Thread.CurrentThread.ManagedThreadId);
            Task<string> taskForMethod1 = Method1();
            taskForMethod1.ContinueWith(x => {
                Console.WriteLine("Continue Task for Method1 runs on Thread ID : " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Result of taskForMethod1 is : " + x.Result); 
            });
            //taskForMethod1.Wait();
        
            Task<string> task = new Task<string>(Method2);
            Console.WriteLine("Task with Method2 will Start");
            task.Start();
            Console.WriteLine(task.Result);
            Console.WriteLine("End Of Main Thread");
        }

        private Task<string> Method1()
        {
            return Task.Run(() => { 
                Console.WriteLine("Method1 running on Thread ID: " + Thread.CurrentThread.ManagedThreadId); 
                return "asd"; 
            });
        }

        private string Method2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Method2 run on Thread ID : " + Thread.CurrentThread.ManagedThreadId);
            return "bsd";
        }
    }
}
