using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    public class LambdaSample5
    {
        public void Run()
        {
            int midPoint = 5;
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var queryList = from i in intList
                        where i > midPoint
                        select i;
            foreach (int number in queryList)
            {
                Console.WriteLine(number);
            }

            IEnumerable<int> numbersAboveMidPoint = intList.Where(x => x > midPoint);
            foreach (int number in numbersAboveMidPoint)
            {
                Console.WriteLine(number);
            }
        }
    }
}
