using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    public class LambdaSample1
    {
        public delegate int MyDel(int x, int y);

        public int Sum(int a, int b) { return a + b; }
        public void Run()
        {
            //using delegate
            int a = 21, b = 79;
            MyDel del1 = new MyDel(Sum);
            Console.WriteLine($"Using delegate: Sum of {a} and {b} is: {del1(a, b)}");

            //using anonymous method
            MyDel del2 = delegate(int x, int y) { return x + y; };
            Console.WriteLine("Using anonymous method : Sum of {0} and {1} is : {2}", a, b, del2(11, 22));

            //using Lambda expression
            MyDel del3 = (x, y) => x + y;
            Console.WriteLine($"Using lambda expression: Sum of {2} and {3} is: {del3(2, 3)}");
        }
    }
}
