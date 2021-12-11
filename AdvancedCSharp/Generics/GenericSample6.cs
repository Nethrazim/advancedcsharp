using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    //Restrictions on generic type parameters
    public class GenericSample6
    {
        interface IEmployee { }
        class EmployeeStoreHouse<T> where T : IEmployee { } // T implements interface IEmployee
        class EmployeeFHouse<T> where T : IEmployee, new() { } // new() means the type T must have a default parameterless constructor, must be the last contraint
    }
}
