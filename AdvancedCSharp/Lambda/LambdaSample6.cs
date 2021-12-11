using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    public class LambdaSample6    {
        
        delegate Tuple<int, double> MakeDoubleDelegate(Tuple<int, double> input);

        public void Run()
        {
            var inputTuple = Tuple.Create(1, 2.3);
            var resultTuple = MakeDoubleMethod(inputTuple);
            MakeDoubleDelegate delegateObject = (Tuple<int, double> input) => Tuple.Create(input.Item1 * 2, input.Item2 * 2);
        }

        Tuple<int, double> MakeDoubleMethod(Tuple<int, double> input)
        {
            return Tuple.Create(input.Item1 * 2, input.Item2 * 2);
        }
    }
}
