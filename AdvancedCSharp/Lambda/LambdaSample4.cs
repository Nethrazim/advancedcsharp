using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    public class LambdaSample4
    {
        public class Employee
        {
            private string name;
            private string company;
            public int empId { get; private set; }
            public Employee(int id)
            {
                empId = id;
            }

            public Employee(string name) => this.name = name; // Constructor with expression bodied method
            public string Name => name;
            public string Company
            {
                get => name;
                set => name = value;
            }
        }


        public void Run()
        {
            
        }
    }
}
