using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp.Threads
{
    internal class ThreadSample1
    {
        static Thread threadOne;
        static Thread threadTwo;
        static Thread threadThree;
        static Thread threadFour;
        public void Run()
        {
            threadOne = new Thread(Method1);
            threadTwo = new Thread(Method2);

            //threadOne.Join();//before you start it's obvious you cannot join the thread from the calling thread(in this case the main thread); RuntimeError
            threadOne.Start();
            //threadOne.Join();
            threadTwo.Start();
            
            //threadTwo.Join();
            Console.WriteLine("The main thread has finished while the other two spawned threads have not. Use join the execute them in sequence.");

            //ParameterizedThreadStart delegate
            threadThree = new Thread(new ParameterizedThreadStart(Method3));
            threadThree.Start("a value");

            threadFour = new Thread(new ParameterizedThreadStart(Method4));
            threadFour.Start(new ANiceClass());
        }

        void Method1()
        {
            //threadTwo.Join();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-ThreadOne from Method1() prints {0}", i);
            }
        }

        void Method2()
        {
            threadOne.Join(); //dont join one for another , deadlock!
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("--ThreadTwo from Method2() prints 2.0{0}", i);
            }
        }

        void Method3(object value)
        {
            Console.WriteLine(value);
        }

        void Method4(object value)
        {
            //downcast
            Console.WriteLine("A Nice Class has value : " + ((ANiceClass)value).AValue);
        }

        class ANiceClass
        {
            public int AValue { get; set; } = 10;
        }

    }
}
