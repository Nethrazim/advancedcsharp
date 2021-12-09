using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Delegates;
using AdvancedCSharp.Events;

namespace AdvancedCSharp
{
    internal class Program
    {
        FirstDelegateSample1 ex1 = new FirstDelegateSample1();
        CovarianceWithNonGenericDelegate ex2 = new CovarianceWithNonGenericDelegate();
        ContravarianceWithNonGenericDelegates ex3 = new ContravarianceWithNonGenericDelegates();
        EventSample1 ex4 = new EventSample1();
        static void Main(string[] args)
        {
            new Program().RunSamples();
            Console.ReadKey();

        }

        public void RunSamples()
        {
            //ex1.Run();
            //ex2.Run();
            //ex3.Run();
            ex4.Run();
        }
    }
}
