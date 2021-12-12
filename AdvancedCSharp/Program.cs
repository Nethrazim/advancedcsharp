using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Delegates;
using AdvancedCSharp.Events;
using AdvancedCSharp.Lambda;
using AdvancedCSharp.Generics;
using AdvancedCSharp.Threads;


namespace AdvancedCSharp
{
    internal class Program
    {
        FirstDelegateSample1 ex1 = new FirstDelegateSample1();
        CovarianceWithNonGenericDelegate ex2 = new CovarianceWithNonGenericDelegate();
        ContravarianceWithNonGenericDelegates ex3 = new ContravarianceWithNonGenericDelegates();
        EventSample1 ex4 = new EventSample1();
        LambdaSample1 ex5 = new LambdaSample1();
        LambdaSample2 ex6 = new LambdaSample2();
        LambdaSample3 ex7 = new LambdaSample3();
        LambdaSample4 ex8 = new LambdaSample4();
        LambdaSample5 ex9 = new LambdaSample5();
        GenericSample1 ex10 = new GenericSample1();
        GenericSample2  ex11 = new GenericSample2();
        GenericSample3 ex12 = new GenericSample3();
        GenericSample4 ex13 = new GenericSample4();
        GenericSample5 ex14 = new GenericSample5();
        GenericSample7 ex15 = new GenericSample7();
        GenericsSample8 ex16 = new GenericsSample8();
        ThreadSample1 ex17 = new ThreadSample1();
        ThreadSample2 ex18 = new ThreadSample2();
        ThreadSample3 ex19 = new ThreadSample3();
        ThreadSample4 ex20 = new ThreadSample4();
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
            //ex4.Run();
            //ex5.Run();
            //ex6.Run();
            //ex7.Run();
            //ex8.Run();
            //ex9.Run();
            //ex10.Run();
            //ex11.Run();
            //ex12.Run();
            //ex13.Run();
            //ex14.Run();
            //ex15.Run();
            //ex16.Run();
            //ex17.Run();
            //ex18.Run();
            //ex19.Run();
            ex20.Run();
        }
    }
}
