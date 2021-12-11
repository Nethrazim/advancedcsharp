using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    public class GenericSample1
    {
        //This must use overloaded methods
        class NonGenericClassDemo
        {
            public string Display(string value)
            {
                return value;
            }

            public float Display(float value)
            {
                return value;
            }
        }

        class GenericClassDemo<T>
        {
            public T Display(T value)
            {
                return value;
            }
        }

        public void Run()
        {
            NonGenericClassDemo ngcd = new NonGenericClassDemo();
            ngcd.Display("asd");
            ngcd.Display(2.0f);

            GenericClassDemo<string> gcd1 = new GenericClassDemo<string>();
            Console.WriteLine(gcd1.Display("asd"));
            
            GenericClassDemo<float> gcd2 = new GenericClassDemo<float>();
            Console.WriteLine(gcd2.Display(2.0f));
        }
    }
}
