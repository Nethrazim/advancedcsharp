using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    //Expression Bodies Methods
    public class LambdaSample3
    {
        public int CalculateSum1(int a, int b)
        {
            return a + b;
        }

        public int CalculateSum2(int a, int b) => a + b; // can be used when the function can be expressed with a single expression
        
        /* Canot be used because the function is express with multiple expressions
        public int CalculateSum3(int a, int b) => {
            int sum = a + b;
            return sum;
        };
        */

        public void Run()
        {
            CalculateSum2(2, 6);
        }
    }
}
