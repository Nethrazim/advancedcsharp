using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    public class GenericSample2
    {
        public void Run()
        {
            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add(2);
            myList.Add("InvalidElement"); // no compiletime error because ArrayList is non-generic

            foreach (int myInt in myList) // throws a runtime error because of automatic downcasting
            {
                Console.WriteLine(myInt);
            }

            List<int> myGenericList = new List<int>();
            myGenericList.Add(1);
            //myGenericList.Add("InvalidElement"); //this throws a compile time error
        }
    }
}
