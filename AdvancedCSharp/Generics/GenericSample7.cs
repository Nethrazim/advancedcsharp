using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    //private class PrivateClass { } //FYI error, top level class cannot be private/protected
    class GenericSample75 // by default this is internal , accessible to this assembly only
    {
        private class P { } //FYI private class can only be internal and not top level class in the namespace
        protected class P1 { } //FYI same to protected
    
        
    }
}
