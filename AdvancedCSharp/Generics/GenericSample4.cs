using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    public class GenericSample4
    {
        class MyClass
        {

        }

        struct MyStruct
        {

        }

        private void PrintDefault<T>()
        {
            T defaultValue = default(T);
            string printMe = String.Empty;
            printMe = (defaultValue == null) ? "null" : defaultValue.ToString();
            Console.WriteLine($"Default value of {typeof(T)} is {printMe}");
        }

        public void Run()
        {
            PrintDefault<int>();
            PrintDefault<double>();
            PrintDefault<bool>();
            PrintDefault<string>();
            PrintDefault<int?>();
            PrintDefault<Complex>();
            PrintDefault<System.Collections.Generic.List<int>>();
            PrintDefault<System.Collections.Generic.List<string>>();
            PrintDefault<MyClass>();
            PrintDefault<MyStruct>();
        }
    }
}
