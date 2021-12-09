using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegates
{
    // YOU CAN UNCOMMENT THIS PART, BUT THEN DELETE the delegate declaration inside class FirstDelegateSample
    //public delegate int DelegateToSum(int x, int y); //delegate is a class type , can be defined in the namespace, inside a class , outside a class
    public class FirstDelegateSample1 : DelegateSample
    {

        public delegate int DelegateToSum(int x, int y);
        public DelegateToSum sample { get; set; }
        public FirstDelegateSample1()
        {
            sample = new DelegateToSum(Sum); 
        }

        public int Sum(int a, int b)
        {
            Console.WriteLine($"Sum({a},{b}) = {a + b}");
            return a + b;
        }
        public int Diff(int a, int b)
        {
            Console.WriteLine($"Diff({a},{b}) = {a - b}");
            return a - b;
        }

        public static int Prod(int a, int b)
        {
            Console.WriteLine("\nRunning a static method.");
            Console.WriteLine($"Prod({a},{b}) = {a * b}");
            return a * b;
        }

        public override void Run()
        {
            Sum(1, 2);
            Console.WriteLine("delegate sum:: " + sample(1, 2));
            Console.WriteLine("delegate method name:: " + sample.Method.Name);
            sample += Diff;
            Console.WriteLine($"delegate has now {sample.GetInvocationList().Length} invocations Length:: ");
            foreach (var invEl in sample.GetInvocationList())
            {
                Console.WriteLine(invEl.Method);
            }
            RunSpecificMethod("Sum", 11, 22);
            RunSpecificMethod("Diff", 22, 11);

            RunSpecificMethod("Diff", 11, 22);
            RunSpecificMethod("Diff", 22, 11);

            RunSpecificMethod("ASD", 6, 7);

            Console.WriteLine("\n\nIf delegate has many invocations, they will all be executed in the add order:");
            sample(1, 2);

            sample += Prod;
            RunSpecificMethod("Prod", 10, 33);
        }

        public void RunSpecificMethod(string method, int a, int b)
        {
            var _method = sample.GetInvocationList().FirstOrDefault(il => il.Method.Name == method);
            if (_method != null)
            {
                Console.WriteLine("\n" + (_method.Target != null ? _method.Target.ToString() : "Target is null because invocation on static method"));
                _method.DynamicInvoke(a, b);
            }
            else
            {
                Console.WriteLine("Invocation method not found");
            }
                
        }
    }
}
