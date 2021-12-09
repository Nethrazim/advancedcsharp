using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Delegates;

namespace AdvancedCSharp
{
    internal class Program
    {
        FirstDelegateSample1 ex1 = new FirstDelegateSample1();
        CovarianceWithNonGenericDelegate ex2 = new CovarianceWithNonGenericDelegate();
        static void Main(string[] args)
        {
            new Program().RunSamples();
            Console.ReadKey();

        }

        public void RunSamples()
        {
            //ex1.Run();
            ex2.Run();
        }
    }
}
