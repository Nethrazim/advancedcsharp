using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    public class LambdaSample2
    {
        public delegate void DelegateWithNoParameter();
        public delegate void DelegateWithOneParameter(int x);
        public delegate int DelegateWithOneParameterAndReturnType(int x);
        public delegate void DelegateWithTwoIntParameters(int x, int y);
        public delegate void DelegateWithDelegateParameter(DelegateWithOneParameterAndReturnType del, int value);

        public void Run()
        {
            Method1(2, 3);
            DelegateWithNoParameter delWithNoParameter = () => Console.WriteLine("Lambda function with no parameter");
            delWithNoParameter();

            DelegateWithOneParameter delegateWithOne = (x) => { Console.WriteLine($"Lambda With One x * x = {x * x}"); };
            delegateWithOne(2);

            DelegateWithOneParameterAndReturnType delegateWithOneAndReturn = (x) => x * x;
            Console.WriteLine($"Delegate with one param and return type {delegateWithOneAndReturn(3)}");
            
            DelegateWithTwoIntParameters delegateWithTwo = (x, y) => { Console.WriteLine($"Delegate with two params {x * y}"); };
            delegateWithTwo(7,3);

            DelegateWithDelegateParameter delegateWithDelegate = (x, value) => { Console.WriteLine($"Lambda with delegate parameter: {x(value)}");  };
            delegateWithDelegate(delegateWithOneAndReturn, 10);
        }

        private void Method1(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
