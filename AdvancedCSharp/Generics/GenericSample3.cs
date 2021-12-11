using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    //Generic delegates : Func,Action,Predicate
    public class GenericSample3
    {
        public delegate string MyDelegate(string n, int r, double d);
        public void Run()
        {
            MyDelegate del1 = DisplayEmployeeDetails;
            Console.WriteLine(del1("asd", 1, 2000));

            Func<string, int, double, string> func1 = DisplayEmployeeDetails;
            Console.WriteLine(func1("asd", 1, 250));

            Action<int, int, int> action1 = CalculateSumOfThreeInts;
            action1(1, 2, 3);

            Predicate<int> predicate1 = IsGreaterThan100;
            Console.WriteLine(predicate1(101));
        }

        private string DisplayEmployeeDetails(string name, int empId, double salary)
        {
            return $"Employee Name: {name}, id: {empId}, salary: {salary}";
        }

        private void CalculateSumOfThreeInts(int i1, int i2, int i3)
        {
            int sum = i1 + i2 + i3;
            Console.WriteLine(sum);
        }

        private static bool IsGreaterThan100(int input)
        {
            return input > 100 ? true : false;
        }
    }
}
