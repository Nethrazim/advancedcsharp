using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    
    public class GenericSample5
    {
        interface GenericInterface<T>
        {
            T GenericMethod(T param);
            void NonGenericMethod();
        }

        class ConcreteClass<T> : GenericInterface<T>
        {
            public T GenericMethod(T param)
            {
                return param;
            }

            public void NonGenericMethod()
            {
                Console.WriteLine("Implementing NonGenericMethod");
            }
        }

        class ConcreteClass2 : GenericInterface<int>
        {
            public int GenericMethod(int param)
            {
                throw new NotImplementedException();
            }

            public void NonGenericMethod()
            {
                throw new NotImplementedException();
            }
        }

        //class ConcretClass3 : GenericInterface<T> { } -- throws compile error because T was not provided to the interface not this class has a type parameter defined to be assigned later

        public void Run()
        {
            GenericInterface<int> concreteInt = new ConcreteClass<int>();
            int myInt = concreteInt.GenericMethod(1);
            concreteInt.NonGenericMethod();

            GenericInterface<string> concreteString = new ConcreteClass<string>();
            concreteString.NonGenericMethod();
            concreteString.GenericMethod("\n");
        }
    }
}
