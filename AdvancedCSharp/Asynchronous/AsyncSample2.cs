using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Asynchronous
{
    internal class AsyncSample2
    {
        public void Run()
        {
            Task taskOne = new Task(MyMethod);
            taskOne.Start();

            TaskFactory taskFactory = new TaskFactory();

            Task taskTwo = taskFactory.StartNew(MyMethod);
            Task taskThree = Task.Factory.StartNew(MyMethod);
        }

        private static void MyMethod()
        {
            Console.WriteLine("Task.id={0} with Thread id {1} has started.", Task.CurrentId, Thread.CurrentThread.ManagedThreadId); 
            Thread.Sleep(100);
            Console.WriteLine("MyMethod for Task.id={0} and Thread id {1} is completed.", Task.CurrentId.Value.ToString(), Thread.CurrentThread.ManagedThreadId.ToString());
        }
    }
}
