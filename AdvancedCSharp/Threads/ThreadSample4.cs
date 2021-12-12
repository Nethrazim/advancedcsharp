using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
    //Foreground Threads vs Background Threads
    /*
     *By Default a thread is a foreground thread. Convert to a background thread when you set the IsBackground = true 
     *
     *Foreground threads are threads which will continue to run until the last foreground thread is terminated. ... 
     *So when we create a thread the default value of IsBackground property would be false. 
     *
     *Background Threads are threads which will get terminated when all foreground threads are closed
     * 
     */
    internal class ThreadSample4
    {
        //This transforms a Thread from a Foreground(default) to Background. In Program.cs comment the Console.ReadKey() so the Main Threading is not holding for user input.
        // You will notice when the Main Thread terminates also the Background is terminated automatically. 
        public void Run()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine($"{Thread.CurrentThread.Name} has started.");
            Thread childThread = new Thread(MyMethod);
            childThread.Name = "Child Thread-1";
            childThread.Start();
            childThread.IsBackground = true;
            Console.WriteLine("Main Thread finishes before childThread");
        }

        void MyMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from MyMethod() prints{i}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} exist from MyMethod()");
        }

    }
}
